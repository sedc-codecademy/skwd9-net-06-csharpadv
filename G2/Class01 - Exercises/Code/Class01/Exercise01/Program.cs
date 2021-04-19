using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name");
                string name = Console.ReadLine();
                names.Add(name);

                Console.WriteLine("Enter x if you like to stop");
                string input = Console.ReadLine();
                if (input.ToLower() == "x")
                    break;
            }

            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Dictionary<string, int> result = CountAppearances(names, text);
            Console.ReadLine();
        }

        private static Dictionary<string, int> CountAppearances(List<string> names, string text)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            string[] textArr = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in names)
            {
                if (!results.ContainsKey(name))
                {
                    results.Add(name, textArr.Count(x => x.Trim().ToLower() == name.Trim().ToLower()));
                }
            }

            return results;
        }
    }
}
