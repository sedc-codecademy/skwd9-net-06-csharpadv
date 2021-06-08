using System;

namespace LocalStaticFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Caclculate('+', 5, 10);
            var result2 = Caclculate('-', 15, 12);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadLine();
        }

        public static int Caclculate(char operation, int num1, int num2)
        {
            int LocalAdd(int a, int b)
            {
                return a + b;
            };

            int LocalSubtract(int a, int b)
            {
                return a - b;
            };

            switch (operation)
            {
                case '+':
                    return LocalAdd(num1, num2);
                case '-':
                    return LocalSubtract(num1, num2);
                default:
                    return 0;
            }
        }
    }
}
