using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class StringHelper
    {
        /// <summary>
        /// Extension methods, enable you to "add" methods to existing type without creating
        /// a new derived type or otherwise modifying the original type. Extension methods are 
        /// a special kind of static methods, but they are called as if they were instance methods on 
        /// the extended type.
        /// NOTE : The first parameter specifies which type we are extending(string in our example)
        /// and the parameter is preceded by the this keyword always.
        /// In this example, method takes two parameters, string and number of words that we need
        /// to show from that string. 
        /// First we are doing some validations and preventing the user from sending a negative number
        /// or an empty string. This is a good practise in programming called "defensive programming".
        /// </summary>
        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0)
            {
                throw new ArgumentException("numberOfWords can not be a negative number");
            }
            if(str.Length == 0)
            {
                return string.Empty; // ""
            }

            string[] words = str.Split(" ");

            if (words.Length <= numberOfWords)
                return str;

            List<string> wordsResult = words.Take(numberOfWords).ToList(); //take [numberOfWords] members from words List
            return string.Join(" ", wordsResult); // make a new string by joining wordsResult members and separating with space
        }
    }
}
