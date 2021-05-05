using ClassGenericsDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassGenericsDemo.Database
{
    public static class Storage
    {
        public static List<Product> Products { get; set; }
        public static List<Order> Orders { get; set; }

        static Storage()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
        }

        //public static void AddProduct(int id, string title, string description)
        //{
        //    Console.WriteLine("User has entered new product item");
        //    Products.Add(new Product { Id = id, Title = title, Description = description });
        //}

        public static void AddProduct(Product product)
        {
            Console.WriteLine("LOG: User has entered new product item");
            Products.Add(product);
        }

        public static void AddOrder(Order order)
        {
            Console.WriteLine("LOG: User has entered new order item");
            Orders.Add(order);
        }

        public static void RemoveByIdProduct(int id)
        {
            Product p = Products.FirstOrDefault(x => x.Id == id);

            if(p == null)
            {
                Console.WriteLine($"Product with id {id} is not found");
            }

            Products.Remove(p);
            Console.WriteLine("LOG: Product has been removed");
        }
    }
}
