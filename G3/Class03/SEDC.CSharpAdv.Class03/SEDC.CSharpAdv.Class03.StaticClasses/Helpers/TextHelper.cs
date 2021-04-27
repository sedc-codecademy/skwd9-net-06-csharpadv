using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.StaticClasses.Helpers
{
    public static class TextHelper
    {
        public static int MessageGenerated = 0;

        public static int ValidateNumberInput(string input)
        {
            bool isValidChoise = int.TryParse(input, out int choise);
            if (!isValidChoise)
            {
                Console.WriteLine("Wrong input...");
                return -1;
            }
            return choise;
        }
    }
}
