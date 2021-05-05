using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public class NonGenericHelper
    {
        public void GoThroughStings(List<string> items)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForStrings(List<string> items)
        {
            string first = items[0];
            Console.WriteLine($"This list has {items.Count} members and is of type {first.GetType().Name}");
        }

        public void GoThroughIntegers(List<int> items)
        {
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForIntegers(List<int> items)
        {
            int first = items[0];
            Console.WriteLine($"This list has {items.Count} members and is of type {first.GetType().Name}");
        }
    }
}
