using Static.Entities;
using Static.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static
{
    public static class OrdersDb
    {
        public static int OrderId = 5;
        public static List<User> Users { get; set; }
        public static List<Order> Orders { get; set; }

        static OrdersDb()
        {
            Orders = new List<Order>()
            {
                new Order(1, "book of books",  OrderStatus.Delivered),
                new Order(2, "keyboard",  OrderStatus.Processed),
                new Order(3, "Shoes", OrderStatus.Processed),
                new Order(4, "Set of Pens",  OrderStatus.Delivered),
                new Order(5, "sticky Notes",  OrderStatus.CouldNotDeliver)
            };

            Users = new List<User>()
            {
                new User(){Id =1, Username = "paul", Address = "Street 1"},
                new User(){Id =2, Username = "ann", Address = "Street 2"}
            };
            Users[0].Orders.Add(Orders[0]);
            Users[1].Orders.Add(Orders[1]);
            Users[1].Orders.Add(Orders[2]);
            Users[0].Orders.Add(Orders[3]);
            Users[0].Orders.Add(Orders[4]);
        }

        public static void PrintAllUsers()
        {
            for(int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Users[i].Username} - {Users[i].Address}");
            }
        }

        public static void AddOrder(int userId, Order order)
        {
            //must assign ID to the order
            order.Id = ++OrderId;
            Orders.Add(order);
            Users.First(x => x.Id == userId).Orders.Add(order);
        }
    }
}
