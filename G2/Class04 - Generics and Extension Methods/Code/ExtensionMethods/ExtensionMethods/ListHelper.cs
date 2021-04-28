using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class ListHelper
    {
        /// <summary>
        /// A Generic extension method that can be called on any list with items and print the list
        /// </summary>
        public static void PrintAll<T>(this List<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// A Generic extension method that can be called on any list with items and get info 
        /// </summary>
        public static string GetInfo<T>(this List<T> items)
        {
            return $"Number of items: {items.Count}, members are of type: {items[0].GetType()}";
        }
    }
}
