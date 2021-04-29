using System;
using System.Collections.Generic;
namespace OrderingApp.Models
{
    public class User
    {
        public User(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}
