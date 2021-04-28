using System.Collections.Generic;
using OrderingSystem_Models.Db;
using System.Linq;
using System;

namespace OrderingSystem_Models
{
    public class User
    {
        public string Username { get; set; }
        public List<Order> Orders { get; set; }

        public User(string userName)
        {
            Username = userName;
            Orders = new List<Order>();

            //if (Storage.Users.Any(x => string.Equals(x.Username, userName, StringComparison.InvariantCultureIgnoreCase)))
            //{
            //    throw new Exception("User with that username already exists");
            //}
        }
    }
}
