using ClassGenericsDemo.Database;
using ClassGenericsDemo.Entities;
using System;

namespace ClassGenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDb<Product> products = new GenericDb<Product>();
            GenericDb<Order> orders = new GenericDb<Order>();
            GenericDb<User> users = new GenericDb<User>();

            Product p1 = new Product
            {
                Id = 1,
                Title = "Coca Cola",
                Description = "Drink"
            };

            Product p2 = new Product
            {
                Id = 2,
                Title = "Chips",
                Description = "Nice Chips"
            };

            products.Add(p1);
            products.Add(p2);
            //Storage.AddProduct(p1);
            //Storage.AddProduct(p2);

            Order o1 = new Order
            {
                Id = 1,
                Address = "Skopje",
                Receiver = "Risto"
            };

            Order o2 = new Order
            {
                Id = 2,
                Address = "Krusevo",
                Receiver = "Radmila"
            };

            //Storage.AddOrder(o1);
            //Storage.AddOrder(o2);
            orders.Add(o1);
            orders.Add(o2);

            User u1 = new User
            {
                Id = 1,
                Name = "Risto"
            };

            User u2 = new User
            {
                Id = 2,
                Name = "Radmila"
            };

            users.Add(u1);
            users.Add(u2);

            users.PrintAll();
            products.PrintAll();
            orders.PrintAll();

            users.RemoveById(1);
            users.PrintAll();

            Console.WriteLine(orders.GetById(2)?.GetInfo());
            Console.WriteLine(products.GetByIndex(0).GetInfo());

        }
    }
}
