using System;
using System.Collections.Generic;
using System.Linq;
using ExtensionMethods.Helpers;

namespace ExtensionMethods
{
    class Program
    {
        //Extension methods enable you to "add" methods to
        //existing types without creating a new derived type, recompiling, or
        //otherwise modifying the original type. Extension methods are static methods,
        //but they're called as if they were instance methods on the extended type.
        static void Main(string[] args)
        {
            //String Extension Methods
            string text = "C# Advanced is an awesome subject with great demos and activities!";

            string TextToUpperCase = text.ToUpper();

            string TextToUpperCaseShortenExtensionMethod = TextToUpperCase.Shorten(3);

            string TextToUpperCaseShorten = Shorten(TextToUpperCase, 3);

            Console.WriteLine(TextToUpperCaseShorten);
            Console.WriteLine(TextToUpperCaseShortenExtensionMethod);

            string quotedString = TextToUpperCaseShorten.QuoteString();
            Console.WriteLine(quotedString);

            string newString = text.ToUpper().Shorten(4).QuoteString();
            Console.WriteLine(newString);

            //Generic Extension Method
            List<string> strings = new List<string>() { "str1", "str2", "str3" };
            List<int> ints = new List<int>() { 5, 22, -18 };
            List<bool> bools = new List<bool> { true, false, true };

            strings.GoThrough();
            ints.GoThrough();
            bools.GoThrough();

            strings.GetInfoFor();
            ints.GetInfoFor();
            bools.GetInfoFor();

            //Action<string, int> functionBody = (str, index) => Console.WriteLine($"{index + 1}) {str}");
            strings.ForEachWithIndex((str, index) => Console.WriteLine($"{index + 1}) {str}"));
        }

        public static string Shorten(string inputString, int numberOfWords) 
        {
            string[] words = inputString.Split(" ");

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);

            return result + " ...";
        }

        
    }
}
