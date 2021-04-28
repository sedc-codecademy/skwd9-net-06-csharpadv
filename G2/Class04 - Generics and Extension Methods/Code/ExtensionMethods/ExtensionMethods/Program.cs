using ExtensionMethods.Entities;
using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "hello", "hi", "bye" };
            strings.PrintAll();

            List<bool> bools = new List<bool> { true, false, true };
            bools.PrintAll();

            Console.WriteLine(strings.GetInfo());
            Console.WriteLine(bools.GetInfo());
            Console.WriteLine(new List<int> { 1, 2, 3, 4}.GetInfo());

            Console.WriteLine("Hello from SEDC on this sunny day".Shorten(3));

            Test test = new Test();
            test.PrintMessage();

            Console.ReadLine();
        }
    }
}
