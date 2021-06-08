using System;

namespace LocalStaticFunctions
{
    class Program
    {
        public static int Calculate(char operation, int num01, int num02)
        {
            // local functions
            int LocalAdd(int a, int b) { return a + b; };
            //Func<int, int, int> LocalAddLambda = (int a, int b) => a + b;
            int LocalSubtract(int a, int b) { return a - b; };

            int result = operation switch
            {
                '+' => LocalAdd(num01, num02),
                '-' => LocalSubtract(num01, num02),
                _ => throw new ArgumentException("Not valid operation")
            };
            return result;
        }
        static void Main(string[] args)
        {
            // Adding local function in Main
            void SayHello(string name) { Console.WriteLine($"Hello {name}!"); };

            SayHello("Pane");
            // lines
            SayHello("Jelena");

            // Working with method that has local functions
            Console.WriteLine($"7 + 8 = {Calculate('+', 7,8)}");
            Console.WriteLine($"7 - 2 = {Calculate('-', 7, 2)}");
            Console.ReadLine();
        }
    }
}
