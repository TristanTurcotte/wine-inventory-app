﻿using System;
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

        // Static Constructor
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
