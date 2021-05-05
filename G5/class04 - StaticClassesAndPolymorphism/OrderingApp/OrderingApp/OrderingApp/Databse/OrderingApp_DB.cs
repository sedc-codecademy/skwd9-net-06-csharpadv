using OrderingApp.Enums;
using OrderingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingApp.Databse
{
    public static class OrderingApp_DB
    {
		public static int orderId = 5;
        public static List<Order> Orders { get; set; }
        public static List<User> Users { get; set; }

        static OrderingApp_DB()
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
				new User(13, "Jill", "Wayne St. 109a")
			};

			Users[0].Orders.Add(Orders[0]);
			Users[0].Orders.Add(Orders[1]);
			Users[0].Orders.Add(Orders[2]);
			Users[1].Orders.Add(Orders[3]);
			Users[1].Orders.Add(Orders[4]);
		}

		public static void ListUsers() 
		{
			var i = 1;
			Users.ForEach(user => Console.WriteLine($"{i++}) {user.Username}"));
		}

		public static void InsertOrder(int userId, Order order) 
		{
			order.Id = ++orderId;
			Orders.Add(order);
			Users.Where(user => user.Id == userId).FirstOrDefault().Orders.Add(order);
			Console.WriteLine("Order successfully added!");
		}

		public static void DeleteOrder(int userId, int orderId) 
		{
			Order orderForDelete = Orders.Where(order => order.Id == orderId).FirstOrDefault();
			Orders.Remove(orderForDelete);

			User user = Users.Where(user => user.Id == userId).FirstOrDefault();
			user.Orders.Remove(orderForDelete);

			Console.WriteLine("Order successfully removed!");
		}
    }
}
