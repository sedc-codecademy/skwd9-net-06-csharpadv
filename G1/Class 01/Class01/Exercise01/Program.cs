using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            //List<string> stoppedKey = new List<string>() {"x", "X"};

            //while (true)
            //{
            //    Console.WriteLine("Please enter a word:");
            //    string word = Console.ReadLine();

            //    words.Add(word);

            //    Console.WriteLine("If you want to enter another word press any other key then X");
            //    string proceedStatement = Console.ReadLine();

            //    if (proceedStatement == "X" || proceedStatement == "x")
            //    {
            //        break;
            //    }
            //}

            //do
            //{
            //    Console.WriteLine("Please enter a word:");
            //    string word = Console.ReadLine();

            //    words.Add(word);

            //    Console.WriteLine("If you want to enter another word press any other key then X");
            //    string proceedStatement = Console.ReadLine();

            //    if (proceedStatement == "X" || proceedStatement == "x")
            //    {
            //        break;
            //    }

            //} while (true);

            do
            {
                Console.WriteLine("Please enter a word:");
                string word = Console.ReadLine();

                words.Add(word);

                Console.WriteLine("If you want to enter another word press any other key then X");
            } while (Console.ReadLine().ToLower() != "x");
            //while (!stoppedKey.Contains(Console.ReadLine()));

            Console.WriteLine("Please enter the text:");
            string text = Console.ReadLine();

            List<string> textWords = text.Split(" ").ToList();

            foreach (string word in words)
            {
                //int wordCount = textWords
                //    .Where(x => string.Equals(x, word, StringComparison.InvariantCultureIgnoreCase)).ToList().Count;

                int wordCount = textWords.Count(x => string.Equals(x, word, StringComparison.InvariantCultureIgnoreCase));

                Console.WriteLine($"{word}: {wordCount}");
            }
        }
    }
}
