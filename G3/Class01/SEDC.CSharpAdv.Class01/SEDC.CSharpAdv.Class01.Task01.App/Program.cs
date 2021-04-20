using SEDC.CSharpAdv.Class01.Task01.Logic.Models;
using SEDC.CSharpAdv.Class01.Task01.Logic.Services;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class01.Task01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = EnterNamesFromScreen();

            //Console.WriteLine("Enter the text for cheking");
            //string text = Console.ReadLine();

            List<string> names = new List<string>()
            {
                "Nulla",
                "Lorem",
                "eros",
                "dolor",
                "Vestibulum",
                "Hello"
            };

            string text = $"Lorem ipsum dolor sit amet, consectetur Hello dolor dolor  Lorem  Lorem  adipiscing elit. dolor Lorem Hello Vestibulum pharetra Lorem mattis libero, eget porttitor eros posuere eu. Quisque sit amet maximus eros. Donec id placerat massa, dignissim fermentum mi. Pellentesque habitant morbi tristique senectus  Hello et netus et malesuada fames ac turpis egestas. Vestibulum eleifend sem eu velit fermentum eleifend at sed justo. Cras fermentum elementum placerat. Morbi metus tortor, consectetur vehicula leo a, Hello lacinia eleifend quam. Vivamus quis quam Hello Hello quis justo dignissim pulvinar.Aliquam iaculis augue lorem, ac fermentum lorem gravida sit amet.Nulla consectetur lacus felis, at cursus elit mattis ut. Fusce sed congue dolor. Hello Nulla tempus  Hello laoreet velit. Hello";

            SearchService searchService = new SearchService();

            searchService.CountApperancesInText(text, names);

            Console.WriteLine("=========");
            Dictionary<string, int> result = searchService.CountApperancesInText1(text, names);

            foreach(KeyValuePair<string, int> pair in result)
            {
                Console.WriteLine($"Name: {pair.Key} is contained {pair.Value} times");
            }

            Console.WriteLine("=========");
            List<SearchResult> result1 = searchService.CountApperancesInText2(text, names);

            foreach(SearchResult searchResult in result1)
            {
                Console.WriteLine($"Name: {searchResult.Name} is contained {searchResult.Appearance} times");
            }

            Console.ReadLine();
        }

        static List<string> EnterNamesFromScreen()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Please enter names that you want to be searched:");
            Console.WriteLine("Enter x to finiish the list.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "x" || input == "X")
                {
                    break;
                }
                names.Add(input);
            }
            return names;
        }
    }
}
