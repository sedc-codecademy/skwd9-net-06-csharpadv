using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public static class GenericListHelper
    {
        public static void GoThrough<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetInfoFor<T>(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members and is of type {first.GetType().Name}!");
        }
    }
}
