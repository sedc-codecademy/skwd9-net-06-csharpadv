using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Extensions.Helpers
{
    public static class ListHelpers
    {
        public static void GoThrough<T>(this List<T> list)
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static List<T> GetInfo<T>(this List<T> list)
        {
            T first = list[0];
            Console.WriteLine($"This lisst has {list.Count} members of typr {first.GetType().Name}");
            return list;
        }
    }
}
