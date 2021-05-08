using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.GenericsAndExtensionMethods.Generics.Helpers
{
    public class GenericClassListHelper<T>
    {
        public T GenericProp { get; set; }

        public void GoThrough(List<T> items)
        {
            items.ForEach(x => Console.WriteLine(x));
        }

        public static void GetInfo(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has { items.Count } items and is of type { first.GetType().Name }!");
        }
    }
}
