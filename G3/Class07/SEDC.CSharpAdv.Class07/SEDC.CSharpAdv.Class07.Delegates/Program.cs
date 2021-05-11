using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpAdv.Class07.Delegates
{
    public delegate void SayHello();
    class Program
    {
        public delegate void ShowMessage(string msg, string str);
        public delegate int SumDelegate(int a, int b);

        public delegate bool Filter(int x);
        public delegate void PrintNumber(int x);

        static void Main(string[] args)
        {
            SayHello sayHello = new SayHello(WelcomeMessage);
            SayHello sayHello1 = new SayHello(SaySomething);
            

            //sayHello();
            //sayHello1();

            var example = new Example();
            //sayHello += example.WelcomeMessage;

            //sayHello();

            ShowMessage showMessage = new ShowMessage(example.PrintMessage);
            SumDelegate sumDelegate = new SumDelegate(example.SumOfTwoNumbers);

            //showMessage("Some message here...", "Trajan");
            //var sum = sumDelegate(1, 3);
            //Console.WriteLine(sum);

            SayHello sayHello2 = new SayHello(() => Console.WriteLine("Anonymous function in delegate"));
            //sayHello2();

            ShowMessage showMessage1 =
                new ShowMessage((x, y) => Console.WriteLine($"Im x with value {x}, im y with value {y}"));
            //showMessage1("You have new message", "Nikola");
            SumDelegate sumDelegate1 = new SumDelegate((x, y) => x - y);
            SumDelegate sumDelegate2 = new SumDelegate((x, y) =>
            {
                // complex logic here...
                return x * y;
            });

            var sum1 = sumDelegate1(1, 3);
            var sum2 = sumDelegate2(2, 2);
            //Console.WriteLine(sum1);
            //Console.WriteLine(sum2);

            Action<string, string> action = example.PrintMessage;
            //action("Param1", "Param2");

            Action action1 = () => Console.WriteLine("Im action");
            //SayHello actionParam = new SayHello(action1);

            List<int> listOfIntegers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Filter filter = new Filter(x => (x % 2 != 0));

            var evenNumbers = listOfIntegers.Where(x => (x % 2 == 0)).ToList();
            var oddNumbers = listOfIntegers.Where(x => filter(x)).ToList();

            //PrintNumbers(listOfIntegers, filter);
            //PrintNumbers(listOfIntegers, new Filter(x => x % 3 == 0));

            Filter filter1 = new Filter(CheckIfDivideBy5);
            Filter filter2 = new Filter(x => x % 6 == 0);

            PrintNumbers(listOfIntegers, filter1);
            PrintNumbers(listOfIntegers, filter2);
            PrintNumbers(listOfIntegers, new Filter(x => x % 1 == 1));

            Console.ReadLine();
        }

        static bool CheckIfDivideBy5(int x)
        {
            return x % 5 == 0;
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }

        static void SaySomething()
        {
            Console.WriteLine("Say Something");
        }

        static void PrintNumbers(List<int> list, Filter filter)
        {
            PrintNumber printNumber = new PrintNumber(x =>
            {
                Console.WriteLine($"Number {x} is a cool number");
            });

            PrintNumber printNumber1 = new PrintNumber(x =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Number {x} is not that cool number");
                Console.ResetColor();
            });

            foreach (var item in list)
            {
                if (filter(item))
                {
                    PrintNumbers(item, printNumber);
                }
                else
                {
                    PrintNumbers(item, printNumber1);
                }
            }
        }

        static void PrintNumbers(int number, PrintNumber printNumber)
        {
            printNumber(number);
        }
    }
}
