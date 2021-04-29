using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public static class NonGenericListHelper
    {
        public static void PrintInts(List<int> integers)
        {
            foreach(int number in integers)
            {
                Console.WriteLine(number);
            }
        }
        public static void PrintStrings(List<string> strings)
        {
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public static void GetInfoInts(List<int> ints)
        {
            Console.WriteLine($"Num of members {ints.Count}, namespace {ints[0].GetType()}");
        }

        public static void GetInfoStrings(List<string> strings)
        {
            Console.WriteLine($"Num of members {strings.Count}, namespace {strings[0].GetType()}");
        }
    }
}
