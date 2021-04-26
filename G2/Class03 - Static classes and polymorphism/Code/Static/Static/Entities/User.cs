using System;
using System.Collections.Generic;

namespace Static.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }

        public void PrintOrders()
        {
            for(int i = 0; i< Orders.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Orders[i].Description}");
            }
        }
    }
}
