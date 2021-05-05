using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class04.Extensions.Helpers
{
    public static class StringHelpers
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0)
            {
                throw new ArgumentException("numberOfWords should be greater or equal to 0");
            }

            if(str.Length == 0)
            {
                return string.Empty;
            }

            string[] words = str.Split(" ");

            if(words.Length < numberOfWords)
            {
                return str;
            }

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
