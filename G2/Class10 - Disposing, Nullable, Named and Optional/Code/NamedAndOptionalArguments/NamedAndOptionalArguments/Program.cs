using System;

namespace NamedAndOptionalArguments
{
    class Program
    {
        //all parameters are required
        static void Calculate(int num1, int num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        //all params are required
        static void NoOptionalParams(int n1, int n2, char operation)
        {
            Calculate(n1, n2, operation);
        }
        //only n1 is required
        static void SomeOptionalParams(int n1, int n2 = 2, char operation = '-')
        {
            Calculate(n1, n2, operation);
        }
        //no param is required
        static void AllOptionalParams(int n1 = 5, int n2 = 2, char operation = '-')
        {
            Calculate(n1, n2, operation);
        }
        static void Main(string[] args)
        {
            //NoOptionalParams(2); - ERROR
            NoOptionalParams(2, 3, '+');

            SomeOptionalParams(4, 5, '+');
            SomeOptionalParams(7, 8);
            SomeOptionalParams(9);
            //SomeOptionalParams(); - ERROR
            AllOptionalParams();

            //NAMED ARGUMENTS
            NoOptionalParams(n2: 7, operation: '+', n1: 10);
            NoOptionalParams(11, operation: '-', n2: 12);
            Console.ReadLine();
        }
    }
}
