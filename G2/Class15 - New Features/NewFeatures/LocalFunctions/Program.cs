using System;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            void Greet(string name)
            {
                Console.WriteLine($"Nice to meet you {name}");
            }
            //Add(2, 3);
            Console.WriteLine(Calculate('+', 3, 4));

            Greet("SEDC");

            Console.ReadLine();
        }

        public static int Calculate(char operation, int num1, int num2)
        {
            int Add(int a, int b)
            {
                return a + b;
            };

            int Subtract(int a, int b)
            {
                return a - b;
            }
            switch (operation)
            {
                case '+':
                    return Add(num1, num2);
                case '-':
                    return Subtract(num1, num2);
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}
