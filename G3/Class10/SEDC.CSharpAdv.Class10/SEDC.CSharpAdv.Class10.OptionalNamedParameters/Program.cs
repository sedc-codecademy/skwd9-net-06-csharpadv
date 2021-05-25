using System;

namespace SEDC.CSharpAdv.Class10.OptionalNamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            NoOptional(2, 3, "+");
            // NoOptional(2, 3); // here third param is not optional

            SomeOptional(2, 3);
            SomeOptional(10, 7, "-");

            AllOptional();
            AllOptional(1);
            AllOptional(2, 3);
            AllOptional(5, 7, "-");

            NullParam(3);
            NullParam(null);

            NoOptional(num1: 3, operation: "-", num2: 2);
            NoOptional(10, operation: "+", num2: 7);

            // NoOptional(operation: "+", 10, 7); // we can only do random order if ALL arguments are named

            Console.ReadLine();
        }

        static void CheckOperator(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2}");
                    break;
                default:
                    Console.WriteLine($"The app does not work with {operation}");
                    break;
            }
        }

        static void NoOptional(int num1, int num2, string operation)
        {
            CheckOperator(num1, num2, operation);
        }

        static void SomeOptional(int num1, int num2, string operation = "+")
        {
            CheckOperator(num1, num2, operation);
        }
        
        static void AllOptional(int num1 = 5, int num2 = 3, string operation = "+")
        {
            CheckOperator(num1, num2, operation);
        }

        static void NullParam(int? num1)
        {
            string a = num1 != null ? num1.ToString() : "Null";
            Console.WriteLine(a);
        }
    }
}
