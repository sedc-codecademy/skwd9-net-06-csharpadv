using System;
using GenericsDemo.GenericMethods;
using System.Collections.Generic;
using System.Linq;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //NonGenericListHelper helper = new NonGenericListHelper();
            List<string> names = new List<string> { "Risto", "Radmila", "Aleksandar", "Dejan" };
            List<int> numbers = new List<int> { 33, 44, 55, 66, 77, 88 };
            List<bool> boleans = new List<bool> { false, false, true, false, true };
            List<char> chars = new List<char> { 'a', '2', '3', 'b' };
            List<Human> humans = new List<Human> { new Human("Bob", "Bobsky"), new Human("Peter", "Petrovski") };
            //Console.WriteLine(helper.GetElementsOfTheStringList(names));
            //Console.WriteLine(helper.GetSequenceElementsOfTheStringList(names));

            //Console.WriteLine(NonGenericListHelper.GetElementsOfTheStringList(names));
            //Console.WriteLine(NonGenericListHelper.GetSequenceElementsOfTheStringList(names));

            //Console.WriteLine(NonGenericListHelper.GetElementsOfTheIntList(numbers));
            //Console.WriteLine(NonGenericListHelper.GetSequenceElementsOfTheIntList(numbers));

            //string info = GenericListHelper.GetElementsOfTheList(names);
            string info = GenericListHelper.GetElementsOfTheList<string>(names);
            Console.WriteLine(info);
            Console.WriteLine(GenericListHelper.GetSequenceElementsOfTheList<string>(names));

            Console.WriteLine(GenericListHelper.GetElementsOfTheList<int>(numbers));
            Console.WriteLine(GenericListHelper.GetSequenceElementsOfTheList<int>(numbers));

            Console.WriteLine(GenericListHelper.GetElementsOfTheList<bool>(boleans));
            Console.WriteLine(GenericListHelper.GetSequenceElementsOfTheList<bool>(boleans));

            Console.WriteLine(GenericListHelper.GetElementsOfTheList<char>(chars));
            Console.WriteLine(GenericListHelper.GetSequenceElementsOfTheList<char>(chars));


            //Console.WriteLine(GenericListHelper.GetElementsOfTheList<string>(humans.Select(x => x.Print()).ToList()));

            Console.WriteLine(GenericListHelper.GetElementsOfTheList<Human>(humans));
            Console.WriteLine(GenericListHelper.GetSequenceElementsOfTheList<Human>(humans));


            //SWAP
            //int a = 5;
            //int b = 8;

            //Console.WriteLine($"Before: {a}, {b}");
            //NonGenericHelper.SwapInt(ref a, ref b);
            //Console.WriteLine($"After: {a}, {b}");

            //string a1 = "Risto";
            //string b1 = "Panchevski";

            //Console.WriteLine($"Before: {a1}, {b1}");
            //NonGenericHelper.SwapString(ref a1, ref b1);
            //Console.WriteLine($"After: {a1}, {b1}");

            int a = 5;
            int b = 8;
            //string a = "Risto";
            //string b = "Panchevski";

            Console.WriteLine($"Before: {a}, {b}");
            //GenericHelper.Swap<string>(ref a, ref b);
            GenericHelper.Swap(ref a, ref b);
            Console.WriteLine($"After: {a}, {b}");
        }
    }
}
