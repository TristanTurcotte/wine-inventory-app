using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineInventoryApp.Data
{
    class User
    {
        int UserId { get; }
        string Username { get; set; }
        int AccessLevel { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime LastLoginTime { get; set; }

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
