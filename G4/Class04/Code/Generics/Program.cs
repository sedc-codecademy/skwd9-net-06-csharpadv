using System;
using Generics.Helpers;
using Generics.Entities;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        public static GenericDb<Product> productDb = new GenericDb<Product>();
        public static GenericDb<Order> orderDb = new GenericDb<Order>();
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "string01", "string02", "string03" };
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };
            List<bool> booleans = new List<bool>() { true, true, false, true, false };

            #region Non Generic Helpers
            //Console.WriteLine("-------- Non Generic -------------");
            //NonGenericHelper nonGeneric = new NonGenericHelper();
            //nonGeneric.GoThroughStings(strings);
            //nonGeneric.GetInfoForStrings(strings);
            //nonGeneric.GoThroughIntegers(integers);
            //nonGeneric.GetInfoForIntegers(integers);
            #endregion

            #region Generic Helpers
            //Console.WriteLine("-------- Generic -------------");
            //GenericHelper.GoThrough<string>(strings);
            //GenericHelper.GetInfo<string>(strings);
            //GenericHelper.GoThrough<int>(integers);
            //GenericHelper.GetInfo<int>(integers);
            //GenericHelper.GoThrough<bool>(booleans);
            //GenericHelper.GetInfo<bool>(booleans);
            #endregion

            #region Generic classes
            Console.WriteLine("-------- Generic classes ----------");
            Console.WriteLine("Product DB:");
            productDb.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });
            productDb.Insert(new Product() { Id = 2, Description = "Mechanical", Title = "Keyboard" });
            productDb.Insert(new Product() { Id = 3, Description = "64GB", Title = "USB" });
            productDb.PrintAll();
            Console.WriteLine($"Item with id 2 is: {productDb.GetById(2).GetInfo()}");
            productDb.RemoveById(1);
            productDb.PrintAll();
            Console.WriteLine("Order DB:");
            orderDb.Insert(new Order() { Id = 1, Address = "Bob street 29", Receiver = "Bob" });
            orderDb.Insert(new Order() { Id = 2, Address = "Jill street 31", Receiver = "Jill" });
            orderDb.Insert(new Order() { Id = 3, Address = "Greg street 11", Receiver = "Greg" });
            orderDb.PrintAll();
            Console.WriteLine($"Item with id 2 is: {orderDb.GetById(2).GetInfo()}");
            orderDb.RemoveById(1);
            orderDb.PrintAll();
            #endregion
            Console.ReadLine();
        }
    }
}
