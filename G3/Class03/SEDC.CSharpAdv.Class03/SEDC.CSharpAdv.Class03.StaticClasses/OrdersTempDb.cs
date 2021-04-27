using SEDC.CSharpAdv.Class03.StaticClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class03.StaticClasses
{
    public static class OrdersTempDb
    {
		public static int orderId = 5;

        public static List<User> Users;
        public static List<Order> Orders;

		static OrdersTempDb()
		{
			Orders = new List<Order>()
			{
				new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
				new Order(2, "keyboard", "Mechanical", OrderStatus.DeliveryInProgress),
				new Order(3, "Shoes", "Waterproof", OrderStatus.DeliveryInProgress),
				new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
				new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.CouldNotDeliver)
			};
			Users = new List<User>()
			{
				new User(12, "Bob22", "Bob St. 44"),
				new User(13, "JillCoolCat", "Wayne St. 109a")
			};
			Users[0].Orders.Add(Orders[0]);
			Users[0].Orders.Add(Orders[1]);
			Users[0].Orders.Add(Orders[2]);
			Users[1].Orders.Add(Orders[3]);
			Users[1].Orders.Add(Orders[4]);
		}

		public static void InsertOrder(int userId, Order order)
        {
			order.Id = ++orderId;
			Orders.Add(order);
			Users.FirstOrDefault(u => u.Id == userId).Orders.Add(order);
            Console.WriteLine("Order successfuly added!");
        }

		public static void ListUsers()
        {
			for(int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Users[i].Username}");
            }
        }
	}
}
