using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Paul", "Ana", "Marko", "Mila", "John" };
            List<string> emptyList = new List<string>();

            //FUNC
            // Func always has a return value

            // Example of a Func with no parameters
            // bool -> return value
            Func<bool> isNamesListEmpty = () => names.Count == 0;
            // Exampe of a Func with 1 paramter
            // List<string> -> parameter no. 1 / bool -> return type
            Func<List<string>, bool> isListEmpty = (x) => x.Count == 0;
            // Example of a Func with 2 parameters
            // // int -> parameter no. 1 / int -> parameter no. 2 / int -> return type
            Func<int, int, int> sum = (x, y) => x + y;

            //body with multiple statements
            Func<int, int, bool> isFirstNumLarger = (x, y) =>
            {
                if (x > y)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine($"Check if names is empty: {isNamesListEmpty()}");
            Console.WriteLine($"Check if emptyList is empty: {isListEmpty(emptyList)}");

            Console.WriteLine($"Sum: {sum(2, 3)}");
            Console.WriteLine($"Is 5 larger than 3: {isFirstNumLarger(5, 3)}");
            //ACTION
            // Action is always void

            // Example of an action without parameters
            Action helloMessage = () => Console.WriteLine("Hello from us!");
            // Example of an action with two parameters ( string and ConsoleColor )
            Action<string, ConsoleColor> printMessageInColor = (x, y) =>
            {
                Console.ForegroundColor = y;
                Console.WriteLine(x);
                Console.ResetColor();
            };
            helloMessage();
            printMessageInColor("Hello all", ConsoleColor.Red);

            // We can also use Func to pass it in a LINQ method instead of a direct labmda expression
            string memberMarko = names.FirstOrDefault(x => x == "Marko");
            Func<string, bool> isMarko = x => x == "Marko";
            string foundMemberMarko = names.FirstOrDefault(isMarko);

            Console.WriteLine(foundMemberMarko);

            List<string> namesStartingWithM = names.Where(x => x.StartsWith("M")).ToList();
            Func<string, bool> startsWithM = x => x.StartsWith("M");

            List<string> filteredNames = names.Where(startsWithM).ToList();
            foreach(string name in filteredNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
