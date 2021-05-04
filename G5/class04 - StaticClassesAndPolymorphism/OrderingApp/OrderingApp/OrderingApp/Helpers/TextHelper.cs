using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingApp.Helpers
{
    public static class TextHelper
    {
        public static string CapitalFirstLetter(string input) 
        {
            if (input.Length == 0) 
            {
                return "Empty String";
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static int ValidateNumberInput(string input) 
        {
            bool isMenuChoiceValid = int.TryParse(input, out int choice);

            if (!isMenuChoiceValid) 
            {
                Console.WriteLine("Wrong input...");
                return -1;
            }

            return choice;
        }
    }
}
