using System;
using System.Collections.Generic;
using System.Drawing;

namespace RestaurantApp.Models
{
    public class Restaurant
    {
        public delegate void OrderCompletedDelegate(int orderNumber);

        public event OrderCompletedDelegate OrdersEvent;

        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Restaurant(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void MakeAnOrder(Order order, OrderCompletedDelegate subscriber)
        {
            Orders.Add(order);

            if (OrdersEvent != null)
            {
                OrdersEvent -= subscriber;
            }

            OrdersEvent += subscriber;
        }

        //Method that checks if any order is completed
        public void CheckOrders()
        {
            if (Orders.Count == 0)
                return;

            Random rnd = new Random();
            int randomOrderIndex = rnd.Next(0, Orders.Count);

            Order completeOrder = Orders[randomOrderIndex];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name}: The order with number {completeOrder.Id} is ready!");
            Console.ResetColor();

            OrdersEvent(completeOrder.Id);

            Orders.Remove(completeOrder);
        }
    }
}
