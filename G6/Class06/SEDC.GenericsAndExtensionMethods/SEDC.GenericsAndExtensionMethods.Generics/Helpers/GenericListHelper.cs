using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.GenericsAndExtensionMethods.Generics.Helpers
{
    public class GenericListHelper
    {
        public void GoThrough<T>(List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfo<T>(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has { items.Count } items and is of type { first.GetType().Name }!");
        }
    }
}
