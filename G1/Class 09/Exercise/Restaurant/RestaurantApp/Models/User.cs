using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestaurantApp.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        private List<Order> Orders { get; set; }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Orders = new List<Order>();
        }

        public Order CreateOrder(string name, int price)
        {
            Order newOrder = new Order(name, price);
            Orders.Add(newOrder);

            return newOrder;
        }

        public void OrderCompleteSubscriber(int orderNumber)
        {
            if(Orders.All(x => x.Id != orderNumber))
                return;

            Thread.Sleep(5000);
            Console.WriteLine($"{FullName}: The order with number {orderNumber} is my order.");

            Order completedOrder = Orders.Single(x => x.Id == orderNumber);

            Thread.Sleep(5000);
            Console.WriteLine($"{FullName}: I have picked the order {completedOrder.Id} '{completedOrder.Name}' and I payed {completedOrder.Price:C}");

            Orders.Remove(completedOrder);
        }
    }
}
