using System;

namespace SEDC.CSharpAdv.Class15.LocalStaticFunctions
{
    class Program
    {
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }

        static void Main(string[] args)
        {
            void SayHello(string name) { Console.WriteLine($"Hello {name}"); };

            SayHello("Trajan");

            var result1 = Calculate('+', 5, 5);
            var result2 = Calculate('-', 10, 5);

            Console.WriteLine($"5 + 5 = {result1}");
            Console.WriteLine($"10 - 5 = {result2}");

            Console.ReadLine();
        }

        public static int Calculate(char operation, int num1, int num2)
        {
            int LocalSum(int a, int b) { return a + b; };
            int LocalSubstract(int a, int b) => a - b;

            switch (operation)
            {
                case '+':
                    return LocalSum(num1, num2);
                case '-':
                    return LocalSubstract(num1, num2);
                default:
                    throw new Exception("Please enter a correct opration ( + or -)");
            }
        }
    }
}
