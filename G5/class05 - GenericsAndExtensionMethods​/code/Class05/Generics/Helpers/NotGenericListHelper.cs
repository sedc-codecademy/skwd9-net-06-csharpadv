using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public static class NotGenericListHelper
    {
        public static void GoThroughtStrings(List<string> strings) 
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public static void GetInfoForStrings(List<string> strings) 
        {
            string first = strings[0];
            Console.WriteLine($"This list has {strings.Count} members and is of type {first.GetType().Name}!");
        }

        public static void GoThroughInts(List<int> ints)
        {
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }
        }

        public static void GetInfoForInts(List<int> ints)
        {
            int first = ints[0];
            Console.WriteLine($"This list has {ints.Count} members and is of type {first.GetType().Name}!");
        }
    }
}
