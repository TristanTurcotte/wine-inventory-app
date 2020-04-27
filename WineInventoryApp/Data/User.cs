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
        int UserId { get; }

        /// <summary>
        /// User account's username for a human readable identifier.
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// Access level to various features of the application. The 3 levels being:
        /// Change quantity from Inventory(0), edit and add wine(1), full admin
        /// rights(2).
        /// </summary>
        int AccessLevel { get; set; }

        /// <summary>
        /// Date this user account was created.
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last time this user logged into the application.
        /// </summary>
        DateTime LastLoginTime { get; set; }

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
    }
}
