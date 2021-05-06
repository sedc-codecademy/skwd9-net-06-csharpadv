using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Helpers
{
    public static class ListExtensionMethods
    {
        public static void GoThrough<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetInfoFor<T>(this List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members and is of type {first.GetType().Name}!");
        }

        public static void ForEachWithIndex<T>(this IEnumerable<T> source, Action<T, int> action) 
        {
            var index = 0;
            foreach (T item in source)
            {
                action(item, index++);
            }
        }
    }
}
