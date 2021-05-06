using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Helpers
{
    public static class StringExtensionMethods
    {
        public static string Shorten(this string inputString, int numberOfWords) 
        {
            string[] words = inputString.Split(" ");

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);

            return result + " ...";
        }

        public static string QuoteString(this string inputString) 
        {
            return '"' + inputString + '"';
        }
    }
}
