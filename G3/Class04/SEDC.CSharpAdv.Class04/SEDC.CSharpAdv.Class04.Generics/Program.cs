using SEDC.CSharpAdv.Class04.Generics.DB;
using SEDC.CSharpAdv.Class04.Generics.Entities;
using SEDC.CSharpAdv.Class04.Generics.Helpers;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class04.Generics
{
    class Program
    {
        public static OrderDb OrderNonGeneric = new OrderDb();
        public static ProductDb ProductNonGeneric = new ProductDb();
        public static UserDb UserNonGeneric = new UserDb();

        public static GenericDb<Order> OrderDb = new GenericDb<Order>();
        public static GenericDb<Product> ProductDb = new GenericDb<Product>();
        public static GenericDb<User> UserDb = new GenericDb<User>();
        public static GenericDb<Example> ExampleDb = new GenericDb<Example>();

        // public static GenericDb<string> GenericDb = new GenericDb<string>();

        static void Main(string[] args)
        {
            #region GenericDb
            OrderDb.Insert(new Order() { Id = 1, Address = "Some street 4", Receiver = "Trajan" });
            OrderDb.Insert(new Order() { Id = 2, Address = "Some street 23", Receiver = "Nikola" });
            OrderDb.Insert(new Order() { Id = 3, Address = "Some street 33", Receiver = "Bob" });

            ProductDb.Insert(new Product() { Id = 1, Description = "Product1", Title = "Product1" });
            ProductDb.Insert(new Product() { Id = 2, Description = "Product2", Title = "Product2" });
            ProductDb.Insert(new Product() { Id = 3, Description = "Product3", Title = "Product3" });

            Console.WriteLine("Orders");
            OrderDb.PrintAll();
            Console.WriteLine("Products");
            ProductDb.PrintAll();

            Console.WriteLine("------------ Get By Id From order and product db ----------------");
            Order order = OrderDb.GetById(1);
            Product product = ProductDb.GetById(2);
            Console.WriteLine(order.GetInfo());
            Console.WriteLine(product.GetInfo());

            Console.WriteLine("------------ Get By Index From order and product db ----------------");
            Order order1 = OrderDb.GetByIndex(1);
            Product product1 = ProductDb.GetByIndex(0);
            Console.WriteLine(order1.GetInfo());
            Console.WriteLine(product1.GetInfo());

            Console.WriteLine("------------ Remove item From order and product db ----------------");
            OrderDb.RemoveById(1);
            ProductDb.RemoveById(3);

            Console.WriteLine("Orders");
            OrderDb.PrintAll();
            Console.WriteLine("Products");
            ProductDb.PrintAll();
            #endregion

            Console.Clear();

            List<string> strings = new List<string> { "Trajan", "Nikola", "Bob", "Jill" };
            List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<double> doubles = new List<double> { 1.1, 1.2, 1.3, 2.1, 2.2, 2.3 };

            ListHelper helper = new ListHelper();

            helper.GoThroughStrings(strings);
            helper.GetInfoForString(strings);
            Console.WriteLine("===============");
            helper.GoThroughIntegers(ints);
            helper.GetInfoForInteger(ints);
            Console.WriteLine("=============== GENERIC METHODS");
            helper.GoThrough<string>(strings);
            helper.GetInfo(strings); // the compiler will define the type on its own
            Console.WriteLine("===============");
            helper.GoThrough<int>(ints);
            helper.GetInfo<int>(ints);
            Console.WriteLine("===============");
            helper.GoThrough<double>(doubles);
            helper.GetInfo<double>(doubles);
            Console.WriteLine("===============");
            helper.GetInfo<Order>(OrderDb.GetAll());
            helper.GetInfo<Product>(ProductDb.GetAll());
            Console.WriteLine("===============");

            helper.Print<Order>(OrderDb.GetAll());



            Console.ReadLine();
        }
    }
}
