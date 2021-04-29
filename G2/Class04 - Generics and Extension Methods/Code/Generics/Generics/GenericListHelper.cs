using System;
using System.Collections.Generic;

namespace Generics
{
    public static class GenericListHelper<T>
    {
        public static void PrintMembers(List<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetInfo(List<T> items)
        {
            Console.WriteLine($"Num of members {items.Count}, namespace {items[0].GetType()}");
        }
    }
}
