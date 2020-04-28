using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WineInventoryApp.Data.InventoryDataSetTableAdapters;

namespace WineInventoryApp.Data
{
    static class AppDatabase
    {
        public static readonly int HASH_BYTE_LEN = 32;
        public static readonly int SALT_BYTE_LEN = 16;
        public static readonly int USERNAME_MIN_LEN = 3;

        // Dataset
        private static InventoryDataSet dataSet = new InventoryDataSet();

        // Database table manager
        private static TableAdapterManager tableManager = new TableAdapterManager();

        // Statis Constructor
        static AppDatabase()
        {
            tableManager.UserTableAdapter = new UserTableAdapter();
            tableManager.PasswordTableAdapter = new PasswordTableAdapter();
            tableManager.WineTableAdapter = new WineTableAdapter();
            tableManager.InventoryTableAdapter = new InventoryTableAdapter();
            tableManager.InventoryChangeTableAdapter = new InventoryChangeTableAdapter();
        }

        // Bind methods for GUI
        private static BindingSource GetDataBinding(object data)
        {
            BindingSource bind = new BindingSource();
            bind.DataSource = data;

            return bind;
        }

        public static BindingSource GetUserTableBinding()
        {
            BindingSource bs = GetDataBinding(dataSet.User);

            return bs;
        }

        public static BindingSource GetPasswordTableBinding()
        {
            return GetDataBinding(dataSet.Password);
        }

        public static BindingSource GetWineTableBinding()
        {
            return GetDataBinding(dataSet.Wine);
        }

        public static BindingSource GetInventoryTableBinding()
        {
            return GetDataBinding(dataSet.Inventory);
        }

        public static BindingSource GetInventoryChangeTableBinding()
        {
            return GetDataBinding(dataSet.InventoryChange);
        }

        // USER TABLE
        public static class UserTable
        {
            public static void QueryAllUsers()
            {
                tableManager.UserTableAdapter.Fill(dataSet.User);
            }

            public static void QueryUsersByName(string partialUsername)
            {
                tableManager.UserTableAdapter.FillByContainsUsername(dataSet.User, partialUsername.Trim());
            }

            public static void QueryUsersByAccessLevel(int accessLevel)
            {
                tableManager.UserTableAdapter.FillByAccessLevel(dataSet.User, accessLevel);
            }

            public static List<User> GetAllUsers()
            {
                List<User> users = new List<User>();
                var data = tableManager.UserTableAdapter.GetData();
                foreach (var datum in data)
                {
                    users.Add(new User(datum.UserId, datum.UserName, datum.AccessLevel, datum.CreatedDate, datum.LastLoginTime));
                }

                return users;
            }

            public static User GetUserById(int userId)
            {
                var data = tableManager.UserTableAdapter.GetData().Rows;
                if (data.Count != 1)
                {
                    throw new FormatException($"GetUserById({userId}) returned {data.Count} values.");
                }
                var row = (InventoryDataSet.UserRow)data[0];
                User user = new User(row.UserId, row.UserName, row.AccessLevel, row.CreatedDate, row.LastLoginTime);

                return user;
            }

            /// <summary>
            /// Gets the user id for the given exact match of the string username. Returns -1 if the username is not found.
            /// </summary>
            /// <param name="username">Username to match to the database.</param>
            /// <returns>-1 if and only if the given username is not in the database, otherwise a positive int including 0 is returned.</returns>
            public static int GetUserIdByName(string username)
            {
                var data = tableManager.UserTableAdapter.GetUserByExactUsername(username.Trim()).Rows;
                if (data.Count != 1)
                {
                    return -1;
                }

                return ((InventoryDataSet.UserRow)data[0]).UserId;
            }

            /// <summary>
            /// Checks if the given username matches an exact username in the database.
            /// </summary>
            /// <param name="username">Username to match to the database.</param>
            /// <returns>True, if and only if the given username has an exact match, otherwise false.</returns>
            public static bool ContainsUsername(string username)
            {
                var data = tableManager.UserTableAdapter.GetUserByExactUsername(username.Trim()).Rows;

                return data.Count >= 1;
            }

            public static bool ContainsUserId(int userId)
            {
                var data = tableManager.UserTableAdapter.GetUserById(userId).Rows;

                return data.Count == 1;
            }

            public static void UpdateUserAccessLevel(int userId, int access)
            {
                tableManager.UserTableAdapter.UpdateAccessLevel(userId, access);
            }

            public static void UpdateUsername(int userId, string username)
            {
                string name = username.Trim();

                if (name.Length > USERNAME_MIN_LEN && !ContainsUsername(name))
                {
                    tableManager.UserTableAdapter.UpdateUsername(userId, name);
                }
            }

            public static void UpdateLastLoginTime(int userId, DateTime dateTime)
            {
                tableManager.UserTableAdapter.UpdateLoginTime(userId, dateTime);
            }

            public static int InsertUser(string username, int access, byte[] hash, byte[] salt)
            {
                if (hash.Length != HASH_BYTE_LEN || salt.Length != SALT_BYTE_LEN)
                {
                    throw new ArgumentException($"InsertUser({username}, {access}, byte[{HASH_BYTE_LEN}], byte[{SALT_BYTE_LEN}]): One or more of the given byte arrays are of invalid length.");
                }

                string name = username.Trim();

                if (name.Length > USERNAME_MIN_LEN && !ContainsUsername(name))
                {
                    tableManager.UserTableAdapter.Insert(name, access, DateTime.Today, null);
                    int userId = GetUserIdByName(name);
                    tableManager.PasswordTableAdapter.InsertPassword(userId, hash, salt);

                    return userId;
                }

                return -1;
            }

            public static void DeleteUser(int userId)
            {
                tableManager.PasswordTableAdapter.DeletePassword(userId);

                tableManager.UserTableAdapter.DeleteUser(userId);
            }
        }

        // PASSWORD TABLE
        public static class PasswordTable
        {
            public static byte[] GetPasswordSalt(int userId)
            {
                var data = tableManager.PasswordTableAdapter.GetDataById(userId);
                if (data.Rows.Count != 1)
                {
                    throw new FormatException($"GetPasswordSalt({userId}) returned {data.Rows.Count} values.");
                }

                return ((InventoryDataSet.PasswordRow)data.Rows[0]).Salt;
            }

            public static bool ComparePasswordHash(int userId, byte[] hash)
            {
                if (hash.Length != HASH_BYTE_LEN)
                {
                    return false;
                }

                return tableManager.PasswordTableAdapter.MatchPasswordHash(userId, hash) == 1;
            }

            public static void UpdatePassword(int userId, byte[] hash, byte[] salt)
            {
                if (hash.Length != HASH_BYTE_LEN && salt.Length != SALT_BYTE_LEN)
                {
                    throw new ArgumentException($"UpdatePassword({userId}, byte[{HASH_BYTE_LEN}], byte[{SALT_BYTE_LEN}]): One or more of the given byte arrays are of invalid length.");
                }

                tableManager.PasswordTableAdapter.UpdatePassword(userId, hash, salt);
            }
        }


        // WINE TABLE
        public static class WineTable
        {
            public static void QueryAllWine()
            {
                tableManager.WineTableAdapter.Fill(dataSet.Wine);
            }

            public static void QueryWineByName(string wineName)
            {
                tableManager.WineTableAdapter.FillByWineName(dataSet.Wine, wineName.Trim());
            }

            public static void QueryWineByOrigin(string origin)
            {
                tableManager.WineTableAdapter.FillByOrigin(dataSet.Wine, origin.Trim());
            }

            public static void QueryWineByType(string type)
            {
                tableManager.WineTableAdapter.FillByType(dataSet.Wine, type.Trim());
            }

            public static void QueryWineByYear(int year)
            {
                tableManager.WineTableAdapter.FillByYear(dataSet.Wine, year);
            }

            public static List<Wine> GetAllWine()
            {
                List<Wine> wine = new List<Wine>();
                var data = tableManager.WineTableAdapter.GetData();
                foreach (var w in data)
                {
                    wine.Add(new Wine(w.WineId, w.WineName, w.Origin, w.Price, w.Year, w.Volume, w.Type, w.Image));
                }

                return wine;
            }

            public static Wine GetWineById(int wineId)
            {
                var data = tableManager.WineTableAdapter.GetWineById(wineId).Rows;
                if (data.Count != 1)
                {
                    throw new FormatException($"GetWineById({wineId}) returned {data.Count} values.");
                }
                var row = (InventoryDataSet.WineRow)data[0];
                Wine wine = new Wine(row.WineId, row.WineName, row.Origin, row.Price, row.Year, row.Volume, row.Type, row.Image);

                return wine;
            }

            public static List<Wine> GetWineByName(string wineName)
            {
                List<Wine> wine = new List<Wine>();
                var data = tableManager.WineTableAdapter.GetDataByWineName(wineName);
                foreach (var w in data)
                {
                    wine.Add(new Wine(w.WineId, w.WineName, w.Origin, w.Price, w.Year, w.Volume, w.Type, w.Image));
                }

                return wine;
            }

            public static List<Wine> GetWineByOrigin(string origin)
            {
                List<Wine> wine = new List<Wine>();
                var data = tableManager.WineTableAdapter.GetDataByOrigin(origin);
                foreach (var w in data)
                {
                    wine.Add(new Wine(w.WineId, w.WineName, w.Origin, w.Price, w.Year, w.Volume, w.Type, w.Image));
                }

                return wine;
            }

            public static List<Wine> GetWineByType(string type)
            {
                List<Wine> wine = new List<Wine>();
                var data = tableManager.WineTableAdapter.GetDataByType(type);
                foreach (var w in data)
                {
                    wine.Add(new Wine(w.WineId, w.WineName, w.Origin, w.Price, w.Year, w.Volume, w.Type, w.Image));
                }

                return wine;
            }

            public static List<Wine> GetWineByYear(int year)
            {
                List<Wine> wine = new List<Wine>();
                var data = tableManager.WineTableAdapter.GetDataByYear(year);
                foreach (var w in data)
                {
                    wine.Add(new Wine(w.WineId, w.WineName, w.Origin, w.Price, w.Year, w.Volume, w.Type, w.Image));
                }

                return wine;
            }

            public static int GetIdByName(string wineName)
            {
                var data = tableManager.WineTableAdapter.GetWineByExactName(wineName);
                if (data.Rows.Count != 1)
                {
                    throw new FormatException($"GetIdByName({wineName}) returned {data.Rows.Count} values.");
                }

                return ((InventoryDataSet.WineRow)data.Rows[0]).WineId;
            }

            public static void UpdateWine(int wineId, string wineName, string origin, decimal price, int year, int volume, string type, byte[] image = null)
            {
                tableManager.WineTableAdapter.UpdateWine(wineId, wineName, origin, price, year, volume, type, image);
            }

            public static void InsertWine(string wineName, string origin, decimal price, int year, int volume, string type)
            {
                string wine = wineName.Trim();
                if (wine.Length < 1)
                {
                    throw new ArgumentException("InsertWine: wineName must be at least 1 character");
                }

                tableManager.WineTableAdapter.Insert(wine, origin, price, year, volume, type.Trim(), null);
                int id = GetIdByName(wine);

                tableManager.InventoryTableAdapter.Insert(id, 0);
            }

            public static void DeleteWine(int wineId)
            {
                tableManager.InventoryTableAdapter.DeleteInventory(wineId);

                var data = tableManager.InventoryChangeTableAdapter.GetDataByWineId(wineId);
                foreach (var c in data)
                {
                    tableManager.InventoryChangeTableAdapter.DeleteInventoryChange(c.ChangeId);
                }

                tableManager.WineTableAdapter.DeleteWine(wineId);
            }
        }

        // INVENTORY TABLE
        public static class InventoryTable
        {
            public static void QueryInventory()
            {
                tableManager.InventoryTableAdapter.Fill(dataSet.Inventory);
            }

            public static List<InventoryItem> GetInventory()
            {
                List<InventoryItem> items = new List<InventoryItem>();
                var data = tableManager.InventoryTableAdapter.GetData();
                foreach (var i in data)
                {
                    items.Add(new InventoryItem(i.WineId, i.Quantity));
                }

                return items;
            }

            public static int GetQuantity(int wineId)
            {
                return tableManager.InventoryTableAdapter.GetQuantity(wineId) ?? 0;
            }

            public static void UpdateInventory(int wineId, int quantity, int userId)
            {
                if (!UserTable.ContainsUserId(userId))
                {
                    throw new ArgumentException($"UpdateInventory({wineId}, {quantity}, {userId}*): UserId* does not exist, not performing quantity change");
                }

                int oldQuantity = GetQuantity(wineId);
                int change = quantity - oldQuantity;

                tableManager.InventoryChangeTableAdapter.Insert(userId, wineId, change, DateTime.UtcNow);

                tableManager.InventoryTableAdapter.UpdateInventory(wineId, quantity);
            }
        }

        // INVENTORY CHANGE TABLE
        public static class InventoryChangeTable
        {
            public static void QueryAllChanges()
            {
                tableManager.InventoryChangeTableAdapter.Fill(dataSet.InventoryChange);
            }

            public static void QueryChangesByUser(int userId)
            {
                tableManager.InventoryChangeTableAdapter.FillByUserId(dataSet.InventoryChange, userId);
            }

            public static void QueryChangesByWine(int wineId)
            {
                tableManager.InventoryChangeTableAdapter.FillByWineId(dataSet.InventoryChange, wineId);
            }

            public static List<InventoryChange> GetAllChanges()
            {
                List<InventoryChange> changes = new List<InventoryChange>();
                var data = tableManager.InventoryChangeTableAdapter.GetData();
                foreach (var c in data)
                {
                    changes.Add(new InventoryChange(c.ChangeId, c.UserId, c.WineId, c.QuantityAdjusted, c.DateTimeChanged));
                }

                return changes;
            }

            public static List<InventoryChange> GetChangesByUser(int userId)
            {
                List<InventoryChange> changes = new List<InventoryChange>();
                var data = tableManager.InventoryChangeTableAdapter.GetDataByUserId(userId);
                foreach (var c in data)
                {
                    changes.Add(new InventoryChange(c.ChangeId, c.UserId, c.WineId, c.QuantityAdjusted, c.DateTimeChanged));
                }

                return changes;
            }

            public static List<InventoryChange> GetChangesByWine(int wineId)
            {
                List<InventoryChange> changes = new List<InventoryChange>();
                var data = tableManager.InventoryChangeTableAdapter.GetDataByWineId(wineId);
                foreach (var c in data)
                {
                    changes.Add(new InventoryChange(c.ChangeId, c.UserId, c.WineId, c.QuantityAdjusted, c.DateTimeChanged));
                }

                return changes;
            }
        }
    }
}
