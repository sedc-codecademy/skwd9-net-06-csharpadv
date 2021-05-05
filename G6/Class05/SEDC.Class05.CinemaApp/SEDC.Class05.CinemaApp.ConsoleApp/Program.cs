using CinemaApp.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Class05.CinemaApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can call the extension methods with on the static class
            //ex.
            string threeWordsString = StringHelper.Shorten("My name is Damjan", 3);
            //We can call the extensiom method on an instance of the type that is next to the this first parameter
            //ex
            string empty = string.Empty;
            string result = empty.Shorten(3);
            empty.
            Console.WriteLine(result);
            Console.WriteLine(threeWordsString);
            Console.ReadLine();
        }
    }

    static class StringHelper
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentException("numberOfWords should be greater or equal to 0.");

            if (str.Length == 0)
                return "";

            string[] words = str.Split(' ');

            if (words.Length < numberOfWords)
                return str;

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);

            return result + "...";
        }

        public static string QuoteString(this string text)
        {
            return '"' + text + '"';
        }
    }
}
