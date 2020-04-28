using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using WineInventoryApp.Data;
using System.Diagnostics;

namespace WineInventoryApp.Controller
{
    class Accounts
    {
        public static bool TryLogin(string username, string password)
        {
            // Validate that the username exists
            if (!AppDatabase.UserTable.ContainsUsername(username))
            {
                return false;
            }

            int userId = AppDatabase.UserTable.GetUserIdByName(username);
            byte[] salt = GetUserSalt(userId);
            byte[] inputHash = HashPassword(password, salt);

            return CompareHashedPassword(userId, inputHash);
        }

        /// <summary>
        /// Checks if the given username can be used for a new user. The username must be unique.
        /// </summary>
        /// <param name="username">Unique username with no trailing or leading spaces</param>
        /// <returns></returns>
        public static bool ValidateUsername(string username)
        {
            string name = username.Trim();
            if (name.Length < AppDatabase.USERNAME_MIN_LEN) // Min len of 3
            {
                return false;
            }

            return !AppDatabase.UserTable.ContainsUsername(name);
        }

        /// <summary>
        /// Creates a user with the given username, password and access level. Returns the
        /// UserId of the new user, -1 if a new user could not be created.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accessLevel"></param>
        /// <returns></returns>
        public static int CreateUser(string username, string password, int accessLevel = 1)
        {
            bool validUsername = ValidateUsername(username);
            bool validPassword = password.Length > 3;
            if(!validUsername || !validPassword)
            {
                return -1;
            }

            if(accessLevel < 0)
            {
                accessLevel = 0;
            }

            byte[] salt = GenerateSalt();
            byte[] hash = HashPassword(password, salt);

            Debug.WriteLine("Username: " + username);
            Debug.WriteLine("Password: " + password);
            Debug.WriteLine("Salt: [" + string.Join(", ", salt) + "]");
            Debug.WriteLine("Hash: [" + string.Join(", ", hash) + "]");

            return AppDatabase.UserTable.InsertUser(username, accessLevel, hash, salt);
        }

        /// <summary>
        /// Hashes a given password string into a 256-bit encrypted hash with a 128-bit salt.
        /// </summary>
        /// <param name="password">A validated password string.</param>
        /// <param name="salt">Byte array of 16 elements containing a random salt.</param>
        /// <returns>Byte array of 32 elements containing the hash.</returns>
        private static byte[] HashPassword(string password, byte[] salt)
        {
            byte[] hash = KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 10000,
            numBytesRequested: AppDatabase.HASH_BYTE_LEN); // 256 bits, 32 bytes

            return hash;
        }

        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[AppDatabase.SALT_BYTE_LEN];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        /// <summary>
        /// Checks if the given hash matches the user's stored hash.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="inputHash"></param>
        /// <returns>True, if and only if the given hash is an exact match to the stored hash, otherwise false.</returns>
        private static bool CompareHashedPassword(int userId, byte[] inputHash)
        {
            bool result = AppDatabase.PasswordTable.ComparePasswordHash(userId, inputHash);

            return result;
        }

        private static byte[] GetUserSalt(int userId)
        {
            return AppDatabase.PasswordTable.GetPasswordSalt(userId);
        }
    }
}
