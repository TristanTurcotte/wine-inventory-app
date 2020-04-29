using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WineInventoryApp.Data.InventoryDataSetTableAdapters;

namespace WineInventoryApp.Data
{
    /// <summary>
    /// Controls access to the InventoryDatabase, acts as an interface for the 
    /// rest of the application to read and write to the database.
    /// </summary>
    static class AppDatabase
    {
        /// <summary>
        /// Length in bytes of the password hash.
        /// </summary>
        public static readonly int HASH_BYTE_LEN = 32;

        /// <summary>
        /// Length in bytes of the password salt.
        /// </summary>
        public static readonly int SALT_BYTE_LEN = 16;

        /// <summary>
        /// Minimum character length of a username.
        /// </summary>
        public static readonly int USERNAME_MIN_LEN = 3;

        // Dataset
        private static InventoryDataSet dataSet = new InventoryDataSet();

        // Database table manager
        private static TableAdapterManager tableManager = new TableAdapterManager();
        private static WineInventoryTableAdapter wineInventoryTableAdapater = new WineInventoryTableAdapter();

        // Static Constructor
        static AppDatabase()
        {
            tableManager.UserTableAdapter = new UserTableAdapter();
            tableManager.PasswordTableAdapter = new PasswordTableAdapter();
            tableManager.WineTableAdapter = new WineTableAdapter();
            tableManager.InventoryTableAdapter = new InventoryTableAdapter();
            tableManager.InventoryChangeTableAdapter = new InventoryChangeTableAdapter();
            wineInventoryTableAdapater.Fill(wineInventoryTableAdapater.GetData());
        }

        // Bind methods for GUI
        private static BindingSource GetDataBinding(object data)
        {
            BindingSource bind = new BindingSource();
            bind.DataSource = data;

            return bind;
        }

        /// <summary>
        /// Get a BindingSource that is bound to the User table. Attach this to a DataGridView.
        /// </summary>
        /// <returns>BindingSource to attach to a DataGridView as a datasource.</returns>
        public static BindingSource GetUserTableBinding()
        {
            BindingSource bs = GetDataBinding(dataSet.User);

            return bs;
        }

        /// <summary>
        /// Get a BindingSource that is bound to the Password table. Attach this to a DataGridView.
        /// </summary>
        /// <returns>BindingSource to attach to a DataGridView as a datasource.</returns>
        public static BindingSource GetPasswordTableBinding()
        {
            return GetDataBinding(dataSet.Password);
        }

        /// <summary>
        /// Get a BindingSource that is bound to the Wine table. Attach this to a DataGridView.
        /// </summary>
        /// <returns>BindingSource to attach to a DataGridView as a datasource.</returns>
        public static BindingSource GetWineTableBinding()
        {
            return GetDataBinding(dataSet.Wine);
        }

        /// <summary>
        /// Get a BindingSource that is bound to the Inventory table. Attach this to a DataGridView.
        /// </summary>
        /// <returns>BindingSource to attach to a DataGridView as a datasource.</returns>
        public static BindingSource GetInventoryTableBinding()
        {
            return GetDataBinding(dataSet.Inventory);
        }

        /// <summary>
        /// Get a BindingSource that is bound to the InventoryChange table. Attach this to a DataGridView.
        /// </summary>
        /// <returns>BindingSource to attach to a DataGridView as a datasource.</returns>
        public static BindingSource GetInventoryChangeTableBinding()
        {
            return GetDataBinding(dataSet.InventoryChange);
        }

        /// <summary>
        /// Get a BindingSource that is bound to the WineInventory table. Includes wine quantity.
        /// </summary>
        /// <returns>BindingSource to attach to a DataGridView as a datasource.</returns>
        public static BindingSource GetWineInventoryTableBinding()
        {
            return GetDataBinding(dataSet.WineInventory);
        }

        // USER TABLE
        /// <summary>
        /// Provides methods for accessing and modifying the User table.
        /// </summary>
        public static class UserTable
        {
            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every user in the database.
            /// </summary>
            public static void QueryAllUsers()
            {
                tableManager.UserTableAdapter.Fill(dataSet.User);
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every user in the database with a username that matches the given string.
            /// </summary>
            /// <param name="partialUsername">String to search for.</param>
            public static void QueryUsersByName(string partialUsername)
            {
                tableManager.UserTableAdapter.FillByContainsUsername(dataSet.User, partialUsername.Trim());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every user in the database with the same given access level.
            /// </summary>
            /// <param name="accessLevel">Access level to filter for.</param>
            public static void QueryUsersByAccessLevel(int accessLevel)
            {
                tableManager.UserTableAdapter.FillByAccessLevel(dataSet.User, accessLevel);
            }

            /// <summary>
            /// Get a List of every user in the user table.
            /// </summary>
            /// <returns>List of type User.</returns>
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

            /// <summary>
            /// Get the user object of the given user id.
            /// </summary>
            /// <param name="userId">Which user to get data for.</param>
            /// <returns>User object which matches the database entry.</returns>
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

            /// <summary>
            /// Determines if the database contains the given user ID.
            /// </summary>
            /// <param name="userId">ID to validate.</param>
            /// <returns>True, if and only if the user ID is contained in the table, otherwise false.</returns>
            public static bool ContainsUserId(int userId)
            {
                var data = tableManager.UserTableAdapter.GetUserById(userId).Rows;

                return data.Count == 1;
            }

            /// <summary>
            /// Updates the access level of the given user ID.
            /// </summary>
            /// <param name="userId">User to update.</param>
            /// <param name="access">Access level to be given.</param>
            public static void UpdateUserAccessLevel(int userId, int access)
            {
                tableManager.UserTableAdapter.UpdateAccessLevel(userId, access);
            }

            /// <summary>
            /// Updates the username of the given user ID. The new username must be unique.
            /// </summary>
            /// <param name="userId">User to update.</param>
            /// <param name="username">User's new username.</param>
            public static bool UpdateUsername(int userId, string username)
            {
                string name = username.Trim();

                if (name.Length > USERNAME_MIN_LEN && !ContainsUsername(name))
                {
                    tableManager.UserTableAdapter.UpdateUsername(userId, name);
                    return true;
                }

                return false;
            }

            /// <summary>
            /// Updates the last login time of the given user.
            /// </summary>
            /// <param name="userId">User to update.</param>
            /// <param name="dateTime">Time and date of last login.</param>
            public static void UpdateLastLoginTime(int userId, DateTime dateTime)
            {
                tableManager.UserTableAdapter.UpdateLoginTime(userId, dateTime);
            }

            /// <summary>
            /// Insert a new User entry into the User table. Returns -1 on failure, otherwise
            /// it returns the new user's ID.
            /// </summary>
            /// <param name="username">Username for new user.</param>
            /// <param name="access">Access level for new user.</param>
            /// <param name="hash">Password hash length of 256 bits (32 bytes).</param>
            /// <param name="salt">Password salt length of 128 bits (16 bytes).</param>
            /// <returns>-1, if and only if the user was not created, otherwise returns the new user's ID.</returns>
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

            /// <summary>
            /// Deletes the given user's account from the database. Also deletes the user's
            /// matching Password table entry.
            /// </summary>
            /// <param name="userId">User to delete.</param>
            public static void DeleteUser(int userId)
            {
                tableManager.PasswordTableAdapter.DeletePassword(userId);

                tableManager.UserTableAdapter.DeleteUser(userId);
            }
        }

        // PASSWORD TABLE
        /// <summary>
        /// Provides methods for accessing and modifying the Password table.
        /// </summary>
        public static class PasswordTable
        {
            /// <summary>
            /// Gets the password salt for the given user.
            /// </summary>
            /// <param name="userId">User to get salt for.</param>
            /// <returns>16 byte long array containing the salt.</returns>
            public static byte[] GetPasswordSalt(int userId)
            {
                var data = tableManager.PasswordTableAdapter.GetDataById(userId);
                if (data.Rows.Count != 1)
                {
                    throw new FormatException($"GetPasswordSalt({userId}) returned {data.Rows.Count} values.");
                }

                return ((InventoryDataSet.PasswordRow)data.Rows[0]).Salt;
            }

            /// <summary>
            /// Compares the given password hash to the stored password hash for the
            /// given user.
            /// </summary>
            /// <param name="userId">User to check.</param>
            /// <param name="hash">Input hash to compare.</param>
            /// <returns>true, if and only if the given hash matches the user's stored hash, otherwise false.</returns>
            public static bool ComparePasswordHash(int userId, byte[] hash)
            {
                if (hash.Length != HASH_BYTE_LEN)
                {
                    return false;
                }

                return tableManager.PasswordTableAdapter.MatchPasswordHash(userId, hash) == 1;
            }

            /// <summary>
            /// Updates the given user's password hash and salt.
            /// </summary>
            /// <param name="userId">User to update.</param>
            /// <param name="hash">Hash to save.</param>
            /// <param name="salt">Salt to save.</param>
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
        /// <summary>
        /// Provides methods for accessing and modifying the Wine table.
        /// </summary>
        public static class WineTable
        {
            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine in the database.
            /// </summary>
            public static void QueryAllWine()
            {
                tableManager.WineTableAdapter.Fill(dataSet.Wine);
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine in the database matching the given name.
            /// </summary>
            /// <param name="wineName">Wine name.</param>
            public static void QueryWineByName(string wineName)
            {
                tableManager.WineTableAdapter.FillByWineName(dataSet.Wine, wineName.Trim());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine in the database matching the given country of origin.
            /// </summary>
            /// <param name="origin">Country of origin.</param>
            public static void QueryWineByOrigin(string origin)
            {
                tableManager.WineTableAdapter.FillByOrigin(dataSet.Wine, origin.Trim());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine in the database matching the given type of wine.
            /// </summary>
            /// <param name="type">Type of wine.</param>
            public static void QueryWineByType(string type)
            {
                tableManager.WineTableAdapter.FillByType(dataSet.Wine, type.Trim());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine in the database matching the given vintage year exactly.
            /// </summary>
            /// <params>Vintage year of the wine.</params>
            public static void QueryWineByYear(int year)
            {
                tableManager.WineTableAdapter.FillByYear(dataSet.Wine, year);
            }

            /// <summary>
            /// Get a List of every wine in the wine table.
            /// </summary>
            /// <returns>List of type Wine.</returns>
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

            /// <summary>
            /// Get a wine object matching the given wine id from the Wine table.
            /// </summary>
            /// <param name="wineId">Wine to search for.</param>
            /// <returns>Wine object representing an entry in the database.</returns>
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

            /// <summary>
            /// Get a list of wine objects that match the given name.
            /// </summary>
            /// <param name="wineName">Wine name to search for.</param>
            /// <returns>List of Wine objects matching the given name.</returns>
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

            /// <summary>
            /// Get a list of wine objects that match the given country of origin.
            /// </summary>
            /// <param name="origin">Country of origin.</param>
            /// <returns>List of Wine objects matching the given origin.</returns>
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

            /// <summary>
            /// Get a list of wine objects that match the given wine type.
            /// </summary>
            /// <param name="type">Type of wine.</param>
            /// <returns>List of Wine objects matching the given type of wine.</returns>
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

            /// <summary>
            /// Get a list of wine objects that match the given year.
            /// </summary>
            /// <param name="year">Vintage year of the wine to filter for.</param>
            /// <returns>List of Wine objects matching the given vintage.</returns>
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

            /// <summary>
            /// Gets the wine ID of a wine that matches the given name, vintage, and bottle volume. Returns -1 if
            /// no wine matches the given criteria.
            /// </summary>
            /// <param name="wineName">Name of the wine.</param>
            /// <param name="year">Vintage year.</param>
            /// <param name="volume">Volume of one bottle.</param>
            /// <returns>Wine ID with the given characteristics.</returns>
            public static int GetIdByNameYearVolume(string wineName, int year, int volume)
            {
                var data = tableManager.WineTableAdapter.GetWineByNameYearVolume(wineName, year, volume);
                if(data.Rows.Count == 0)
                {
                    return -1;
                }
                else if (data.Rows.Count != 1)
                {
                    throw new FormatException($"GetIdByName({wineName}) returned {data.Rows.Count} values.");
                }

                return ((InventoryDataSet.WineRow)data.Rows[0]).WineId;
            }

            /// <summary>
            /// Updates the wine entry with the matching Wine ID.
            /// </summary>
            /// <param name="wineId">Wine ID to update.</param>
            /// <param name="wineName">Wine name.</param>
            /// <param name="origin">Country of origin.</param>
            /// <param name="price">Price.</param>
            /// <param name="year">Vintage year.</param>
            /// <param name="volume">Volume of a bottle.</param>
            /// <param name="type">Type of wine.</param>
            /// <param name="image">Wine image. (Not used)</param>
            public static void UpdateWine(int wineId, string wineName, string origin, decimal price, int year, int volume, string type, byte[] image = null)
            {
                tableManager.WineTableAdapter.UpdateWine(wineId, wineName, origin, price, year, volume, type, image);
            }

            /// <summary>
            /// Inserts a new entry into the Wine table.
            /// </summary>
            /// <param name="wineName">Wine name.</param>
            /// <param name="origin">Country of origin.</param>
            /// <param name="price">Price.</param>
            /// <param name="year">Vintage year.</param>
            /// <param name="volume">Volume of a bottle.</param>
            /// <param name="type">Type of wine.</param>
            public static void InsertWine(string wineName, string origin, decimal price, int year, int volume, string type)
            {
                string wine = wineName.Trim();
                if (wine.Length < 1)
                {
                    throw new ArgumentException("InsertWine: wineName must be at least 1 character");
                }
                if(GetIdByNameYearVolume(wine, year, volume) != -1)
                {
                    return;
                }

                tableManager.WineTableAdapter.Insert(wine, origin, price, year, volume, type.Trim(), null);
                int id = GetIdByNameYearVolume(wine, year, volume);

                tableManager.InventoryTableAdapter.Insert(id, 0);
            }

            /// <summary>
            /// Delete the given wine from the database.
            /// </summary>
            /// <param name="wineId">Wine to delete.</param>
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
        /// <summary>
        /// Provides methods for accessing and modifying the Inventory table.
        /// </summary>
        public static class InventoryTable
        {
            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every Inventory item in the database.
            /// </summary>
            public static void QueryInventory()
            {
                tableManager.InventoryTableAdapter.Fill(dataSet.Inventory);
            }

            /// <summary>
            /// Get a list of every InventoryItem in the database.
            /// </summary>
            /// <returns>List of InventoryItems.</returns>
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

            /// <summary>
            /// Get the quantity for the wine matching the given wine ID.
            /// </summary>
            /// <param name="wineId">Wine to get quantity for.</param>
            /// <returns>An integer representing the quantity on hand.</returns>
            public static int GetQuantity(int wineId)
            {
                return tableManager.InventoryTableAdapter.GetQuantity(wineId) ?? 0;
            }

            /// <summary>
            /// Updates the quantity for the given wine. Tracks the user who made the change as well.
            /// </summary>
            /// <param name="wineId">Wine to update.</param>
            /// <param name="quantity">Quantity to change to.</param>
            /// <param name="userId">User who made the change.</param>
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
        /// <summary>
        /// Provides methods for accessing and modifying the InventoryChange table.
        /// </summary>
        public static class InventoryChangeTable
        {
            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every InventoryChange in the database.
            /// </summary>
            public static void QueryAllChanges()
            {
                tableManager.InventoryChangeTableAdapter.Fill(dataSet.InventoryChange);
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every InventoryChange in the database that was created by the given user.
            /// </summary>
            /// <param name="userId">User to filter for.</param>
            public static void QueryChangesByUser(int userId)
            {
                tableManager.InventoryChangeTableAdapter.FillByUserId(dataSet.InventoryChange, userId);
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every InventoryChange in the database that matches the given Wine ID.
            /// </summary>
            /// <param name="wineId">Wine ID to filter for.</param>
            public static void QueryChangesByWine(int wineId)
            {
                tableManager.InventoryChangeTableAdapter.FillByWineId(dataSet.InventoryChange, wineId);
            }

            /// <summary>
            /// Gets a list of every InventoryChange in the database.
            /// </summary>
            /// <returns>List of InventoryChanges.</returns>
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

            /// <summary>
            /// Gets a list of every InventoryChange in the database made by the given user.
            /// </summary>
            /// <param name="userId">User to filter for.</param>
            /// <returns>List of InventoryChanges.</returns>
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

            /// <summary>
            /// Gets a list of every InventoryChange in the database done to the given wine.
            /// </summary>
            /// <param name="wineId">Wine ID to filter for.</param>
            /// <returns>List of InventoryChanges.</returns>
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

        /// <summary>
        /// Provides methods for accessing and the WineInventory table.
        /// </summary>
        public static class WineInventoryTable
        {
            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine inventory item in the database.
            /// </summary>
            public static void QueryAllWineInventory()
            {
                wineInventoryTableAdapater.Fill(wineInventoryTableAdapater.GetData());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine inventory item in the database matching the given name.
            /// </summary>
            /// <param name="wineName">Wine name.</param>
            public static void QueryWineByName(string wineName)
            {
                wineInventoryTableAdapater.FillByWineName(dataSet.WineInventory, wineName.Trim());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine inventory item in the database matching the given country of origin.
            /// </summary>
            /// <param name="origin">Country of origin.</param>
            public static void QueryWineByOrigin(string origin)
            {
                wineInventoryTableAdapater.FillByOrigin(dataSet.WineInventory, origin.Trim());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine inventory item in the database matching the given type of wine.
            /// </summary>
            /// <param name="type">Type of wine.</param>
            public static void QueryWineByType(string type)
            {
                wineInventoryTableAdapater.FillByType(dataSet.WineInventory, type.Trim());
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine inventory item in the database matching the given vintage year exactly.
            /// </summary>
            /// <params>Vintage year of the wine.</params>
            public static void QueryWineByYear(int year)
            {
                wineInventoryTableAdapater.FillByYear(dataSet.WineInventory, year);
            }

            /// <summary>
            /// When a BindingSource is attached to a DataGridView, call this method to fill it with
            /// every wine inventory item in the database having at most the given quantity on hand.
            /// </summary>
            /// <param name="quantity">Quantity on hand.</param>
            public static void QuerryWineByAtMostQuantity(int quantity)
            {
                wineInventoryTableAdapater.FillByAtMostQuantity(dataSet.WineInventory, quantity);
            }
        }
    }
}
