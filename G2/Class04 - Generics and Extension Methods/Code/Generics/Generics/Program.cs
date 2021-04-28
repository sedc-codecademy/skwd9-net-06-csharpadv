using Generics.Entities;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGenericListHelper.PrintInts(new List<int> { 1, 2, 3 });
            NonGenericListHelper.PrintStrings(new List<string> { "hello", "hi" });
            NonGenericListHelper.GetInfoInts(new List<int> { 1, 2, 3 });

            GenericListHelper<string>.PrintMembers(new List<string> { "hello", "hi" });
            GenericListHelper<int>.PrintMembers(new List<int> { 1, 2, 3 });
            GenericListHelper<int>.GetInfo(new List<int> { 1, 2, 3 });

            TwoTypesGenericHelper<int, string>.Print(new Dictionary<int, string>() { { 1, "hello" }, { 2, "hi" } });

            GenericDb<Product>.Insert(new Product() { Id = 1, Description = "Pizza", Title = "Pizza" });
            GenericDb<Product>.Insert(new Product() { Id = 2, Description = "Apple", Title = "Apple" });
            GenericDb<Product>.PrintAll();
            Product product = GenericDb<Product>.GetById(1);
            Console.WriteLine(product.GetInfo());

            GenericDb<Order>.Insert(new Order() { Id = 1, Address = "Street 1", Receiver = "Receiver 1" });
            GenericDb<Order>.Insert(new Order() { Id = 2, Address = "Street 2", Receiver = "Receiver 2" });
            GenericDb<Order>.PrintAll();
            Order order = GenericDb<Order>.GetByIndex(0);
            Console.WriteLine(order.GetInfo());
            
            Console.ReadLine();
        }
    }
}
