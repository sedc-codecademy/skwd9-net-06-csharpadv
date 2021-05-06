using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.GenericsAndExtensionMethods.Generics.Helpers
{
    public class NotGenericListHelper
    {
        public void GoThroughStrings(List<string> strings)
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public void GetInfoForStrings(List<string> strings)
        {
            string first = strings[0];
            Console.WriteLine($"This list has { strings.Count } items and is of type { first.GetType().Name }!");
        }


        public void GoThroughIntegers(List<int> integers)
        {
            foreach (var ints in integers)
            {
                Console.WriteLine(ints);
            }
        }

        public void GetInfoForIntegers(List<int> integers)
        {
            int first = integers[0];
            Console.WriteLine($"This list has { integers.Count } items and is of type { first.GetType().Name }!");
        }
    }
}
