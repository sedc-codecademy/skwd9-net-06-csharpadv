using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Helpers
{
    public static class ListHelper
    {
        // A Generic extension method that can be called on any list with items and print the list
        public static void GoThrough<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        // A Generic extension method that can be called on any list with items and prints info on the list
        public static void GetInfo<T>(this List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members and is of type {first.GetType().Name}");
        }
    }
}
