using SEDC.GenericsAndExtensionMethods.ExtensionMethods.Helpers;
using System;

namespace SEDC.GenericsAndExtensionMethods.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when";
            string second = "Martin and Petre are trainers in G6 group on the Web Development academy in SEDC!";

            Console.WriteLine(first.Shorten(10));
            Console.WriteLine(second.Shorten(5));


            Console.ReadLine();

        }
    }
}
