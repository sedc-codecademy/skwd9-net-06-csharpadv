using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingApp.Models
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
            var i = 1;
            Orders.ForEach(order => Console.WriteLine($"{i++}) Id: {order.Id} - {order.Print()}"));
        }
    }
}
