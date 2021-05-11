using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Bob", "Jill", "Wayne", "Greg", "John", "Anne" };

            List<string> newList = names.Where(name => name == "John").ToList();

            Func<bool> isNamesEmpty = () => names.Count == 0;
            Func<bool> isNamesEmpty2 = () => names.Count > 0;
            Func<int> isNamesEmpty3 = () => 5;

            var result = isNamesEmpty3();
            var result2 = isNamesEmpty();
            Console.WriteLine(result);
            Console.WriteLine(result2);


            bool result3 = CheckNumbers(10, 5, (x, y) => x > y);
            bool result4 = CheckNumbers(10, 5, (x, y) => x == y);
            Console.WriteLine(result3);
            Console.WriteLine(result4);


            // FUNC
            // Func always has a return value 

            // Example of function with no input parameters
            Func<int> robertFunction = () => 3 + 2 + 5;

            // Example of function with 1 input parameter
            Func<List<string>, bool> robertFunction2 = names =>
            {
                return names.Count == 0;
            };

            Func<List<string>, bool> robertFunction3 = names => names.Count == 0;

            // Example of function with 2 input parameters
            Func<string, string, string> careateFullName = (name, lastName) => $"{name} {lastName}";

            var fullName = careateFullName("Viktor", "Jakovlev");
            var fullName2 = careateFullName("Angela", "Kostadinova");

            // ACTION
            // Action is always void


            // Example of action with no input parameters
            Action hello = () => Console.WriteLine("Hello");

            // Example of action with 1 input parameter
            Action<string> helloWithName = inputName => Console.WriteLine($"Hello {inputName}");
            helloWithName("Stefanija");

            Action<string> printRed = inputName =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(inputName);
                Console.ResetColor();
            };

            printRed("Hello Nikola");

            Action<string, ConsoleColor> printStringWithCustomColor = (inputName, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(inputName);
                Console.ResetColor();
            };

            printStringWithCustomColor("Hello Nikola in Yellow", ConsoleColor.Yellow);

            printStringWithCustomColorMethod("Hello Robert", ConsoleColor.Blue, printStringWithCustomColor);

            printStringWithCustomColorMethod("Hello Robert 2", ConsoleColor.Magenta, (name, color) => 
            {
                Console.ForegroundColor = color;
                Console.WriteLine(name);
                Console.ResetColor();
            });
        }

        public static void printStringWithCustomColorMethod(string name, ConsoleColor color, Action<string, ConsoleColor> action) 
        {
            action(name, color);
        }

        public static bool CheckNumbers(int number1, int number2, Func<int, int, bool> func) 
        {
            return func(number1, number2);
        }
    }
}
