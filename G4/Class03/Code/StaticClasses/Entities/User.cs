using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }

        public User(int id, string username, string address)
        {
            Id = id;
            Username = username;
            Address = address;
            Orders = new List<Order>();
        }

        public void PrintOrders()
        {
            Orders.ForEach(order => Console.WriteLine(order.Print()));
        }

        // we can have static members in a non-static class
        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
