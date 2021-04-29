using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    public static class Calculator
    {
        public static double PI { get; set; } = 3.14159;

        public static int Sum(int number1, int number2) 
        {
            return number1 + number2;
        }

        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Add(int number1, int number2)
        {
            return number1 * number2;
        }

        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
