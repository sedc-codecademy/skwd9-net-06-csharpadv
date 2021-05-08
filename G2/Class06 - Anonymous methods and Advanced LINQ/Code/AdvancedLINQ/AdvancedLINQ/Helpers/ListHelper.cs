using AdvancedLINQ.Domain;
using System;
using System.Collections.Generic;

namespace AdvancedLINQ.Helpers
{
    public static class ListHelper
    {
        public static void Print<T>(this List<T> list)
        {
            Console.WriteLine("================");
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
        }

        public static void PrintEntities<T> (this List<T> list) where T : BaseEntity
        {
            Console.WriteLine("================");
            foreach (T item in list)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine("================");
        }
    }
}
