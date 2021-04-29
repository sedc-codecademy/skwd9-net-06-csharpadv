using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public static class TwoTypesGenericHelper<T, U>
    {
        public static void Print(Dictionary<T, U> items)
        {
            foreach(KeyValuePair<T,U> item in items)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }

    }
}
