using SEDC.GenericsAndExtensionMethods.ExtensionMethods.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.GenericsAndExtensionMethods.ExtensionMethods
{

    public class User
    {
        public string FullName { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string first = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when";
            string second = "Martin and Petre are trainers in G6 group on the Web Development academy in SEDC!";
            string third = "Please print this in quotes!";


            Console.WriteLine(first.Shorten(10));
            Console.WriteLine(second.Shorten(5));

            Console.WriteLine(third.QuoteString());
            Console.WriteLine(third.Shorten(2).QuoteString());

            Console.WriteLine("====================================");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<string> names = new List<string> { "Martin", "Petre", "Teodora", "Eva" };

            int sumOfGreaterThanFour = numbers.Where(x => x > 4).Sum();

            numbers.PrintItems();
            names.PrintItems();


            List<User> users = new List<User>
            {
                new User { FullName = "Petre Arsovski" },
                new User { FullName = "Martin Panovski" }
            };
            users.Select(x => x.FullName).ToList().PrintItems();

            Console.ReadLine();

        }
    }
}
