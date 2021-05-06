using Generics.Entities;
using Generics.Helpers;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        public static GenericDB<Order> OrdersDb { get; set; } = new GenericDB<Order>();

        public static GenericDB<Product> ProductsDb = new GenericDB<Product>();

        public static GenericDB<User> UsersDb = new GenericDB<User>();

        static void Main(string[] args)
        {
            //GenericMethods();
            GenericClasses();

            UsersDb.Insert(new User() { Id = 1, Username = "Viktor", Password = "123" });
            var result = UsersDb.GetById(1);
            UsersDb.RemoveById(1);

            Console.ReadLine();
        }

        public static void GenericMethods() 
        {
            //GENERIC METHODS

            List<string> strings = new List<string>() { "str1", "str2", "str3" };
            List<int> ints = new List<int>() { 5, 22, -18 };
            List<bool> bools = new List<bool> { true, false, true };

            //non generic helpers
            NotGenericListHelper.GoThroughtStrings(strings);
            NotGenericListHelper.GetInfoForStrings(strings);
            Console.WriteLine("========");

            NotGenericListHelper.GoThroughInts(ints);
            NotGenericListHelper.GetInfoForInts(ints);
            Console.WriteLine("========");
            Console.WriteLine("========");

            //generic helpers
            GenericListHelper.GoThrough<string>(strings);
            GenericListHelper.GetInfoFor<string>(strings);
            Console.WriteLine("========");

            GenericListHelper.GoThrough<int>(ints);
            GenericListHelper.GetInfoFor<int>(ints);
            Console.WriteLine("========");

            GenericListHelper.GoThrough<bool>(bools);
            GenericListHelper.GetInfoFor<bool>(bools);
            Console.WriteLine("========");
        }

        public static void GenericClasses() 
        {
            //GENERIC CLASSES

            var order = new Order()
            {
                Id = 1,
                Address = "Bob street 29",
                Receiver = "Bob"
            };

            var order2 = new Order()
            {
                Id = 2,
                Address = "Jill street 31",
                Receiver = "Jill"
            };

            var product = new Product()
            {
                Id = 1,
                Description = "For gaming",
                Title = "Mouse"
            };

            OrdersDb.Insert(order);
            OrdersDb.Insert(order2);
            ProductsDb.Insert(product);

            Console.WriteLine("Orders:");
            OrdersDb.PrintAll();

            Console.WriteLine("Products:");
            ProductsDb.PrintAll();

            Console.WriteLine("-------Get by id 1 from Order and Product-------");
            Console.WriteLine(OrdersDb.GetById(1).GetInfo());
            Console.WriteLine(ProductsDb.GetById(1).GetInfo());

            Console.WriteLine("-------Get by index 1 from Order and Product-------");
            Console.WriteLine(OrdersDb.GetByIndex(1).GetInfo());
            Console.WriteLine(ProductsDb.GetByIndex(0).GetInfo());

            Console.WriteLine("-------Remove by id 1 from Order and Product-------");
            OrdersDb.RemoveById(1);
            ProductsDb.RemoveById(1);

            Console.WriteLine("Orders:");
            OrdersDb.PrintAll();

            Console.WriteLine("Products:");
            ProductsDb.PrintAll();
        }
    }
}
