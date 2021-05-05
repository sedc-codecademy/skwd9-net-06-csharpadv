using Generics.Helpers;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericMethods();
            //GenericClasses();

            Console.ReadLine();
        }

        public static void GenericMethods() 
        {
            List<string> strings = new List<string>() { "str1", "str2", "str3" };
            List<int> ints = new List<int>() { 5, 22, -18 };
            List<bool> bools = new List<bool> { true, false, true };

            //non generic helpers
            NotGenericListHelper.GoThroughtStrings(strings);
            NotGenericListHelper.GetInfoForStrings(strings);
            Console.WriteLine("========");

            NotGenericListHelper.GoThroughInts(ints);
            NotGenericListHelper.GetInfoForInts(ints);
            Console.WriteLine("========");
            Console.WriteLine("========");

            //generic helpers
            GenericListHelper.GoThrough<string>(strings);
            GenericListHelper.GetInfoFor<string>(strings);
            Console.WriteLine("========");

            GenericListHelper.GoThrough<int>(ints);
            GenericListHelper.GetInfoFor<int>(ints);
            Console.WriteLine("========");

            GenericListHelper.GoThrough<bool>(bools);
            GenericListHelper.GetInfoFor<bool>(bools);
            Console.WriteLine("========");
        }
    }
}
