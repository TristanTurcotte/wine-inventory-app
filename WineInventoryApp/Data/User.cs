using System;

namespace WineInventoryApp.Data
{
    /// <summary>
    /// Structure which represents the data in the row of the User table.
    /// Each row representing a user's account information, a username,
    /// application access level, account creation date, and last login
    /// time.
    /// </summary>
    class User
    {
        /// <summary>
        /// Primary key user account identifier. Auto-increments by 1.
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// User account's username for a human readable identifier.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Access level to various features of the application. The 3 levels being:
        /// Change quantity from Inventory(0), edit and add wine(1), full admin
        /// rights(2).
        /// </summary>
        public int AccessLevel { get; set; }

        /// <summary>
        /// Date this user account was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last time this user logged into the application.
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// Standard constructor. Used by AppDatabase class to provide a typed
        /// structure to represent a user account.
        /// </summary>
        /// <param name="id">Primary key account identifier.</param>
        /// <param name="name">Account username.</param>
        /// <param name="access">Application access rights.</param>
        /// <param name="created">User account creation date.</param>
        /// <param name="lastLogin">Time and date of last login.</param>
        public User(int id, string name, int access, DateTime created, DateTime lastLogin)
        {
            UserId = id;
            Username = name;
            AccessLevel = access;
            CreatedDate = created;
            LastLoginTime = lastLogin;
        }

        public string AccessString()
        {
            switch(AccessLevel)
            {
                case 0: return "Disabled";
                case 1: return "Waiter";
                case 2: return "Admin";
                case 3: return "Owner";
                default: return "Invalid";
            }
        }

        public override string ToString()
        {
            return string.Format("{{id:{0},name:{1},access:{2},created:{3:d},last:{4}}}", UserId, Username, AccessLevel, CreatedDate, LastLoginTime);
        }

        public static int GetAccessLevelFromString(string access)
        {
            switch (access)
            {
                case "Disabled": return 0;
                case "Waiter": return 1;
                case "Admin": return 2;
                case "Owner": return 3;
                default: return -1;
            }
        }
    }
}
