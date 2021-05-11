using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.GenericsAndExtensionMethods.ExtensionMethods.Helpers
{
    public static class StringHelper
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords <= 0)
                throw new ArgumentException("numberOfWords should be greater than or equal to 0");

            if (str.Length == 0)
                return string.Empty;

            string[] words = str.Split(' ');

            if (words.Length < numberOfWords)
                return str;

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);
            return result + ".... ----> Read more";
        }

        public static string QuoteString(this string str)
        {
            return '"' + str + '"';
        }
    }
}
