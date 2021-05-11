using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionFuncAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            // we use LAMBDA EXPRESSION syntax to write anonymous methods!!!

            // lists to work with Func
            List<string> names = new List<string>()
            {
                "Bob", "Jill", "Wayne", "Greg", "John", "Anne"
            };
            List<string> empty = new List<string>();

            #region Action
            Console.WriteLine("----------- Action ------------");
            // Action - points to anonymous methods that do not return anything
            // no parameter, one line code
            Action hello = () => Console.WriteLine("Hello there!");

            // one parameter of type string, more lines of code {}
            // if one parameter we do not need small brackets
            Action<string> printRed = x =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x);
                Console.ResetColor();
            };

            // two parameters, we need small brackets, more lines of code {}
            Action<string, ConsoleColor> printColor = ( text, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            };

            hello();
            printRed("I will be an ugly red text!");
            printColor("Oh wait! I am even uglier text....", ConsoleColor.Green);
            #endregion

            #region Func
            Console.WriteLine("----------- Func ------------");
            // Func - points to anonymous methods that always return a value

            // no parameters, bool -> return type
            Func<bool> isNamesEmpty = () => names.Count == 0;

            // func with one parameter and return type -> bool
            // RETURN TYPE IS LAST PARAMETER (OR FIRST IF NO PARAMETERS)
            Func<List<string>, bool> isListEmpty = list => list.Count == 0;

            // two parameters - two int, return type -> int, one line fo code
            Func<int, int, int> sum = (x, y) => x + y;

            // two parameters - two int, return type -> bool, more lines of code
            Func<int, int, bool> firstIsLarger = (x, y) =>
            {
                //if (x > y) return true;
                //return false;

                //return x > y ? true : false;

                return x > y;
            };

            Console.WriteLine($" Is Names empty: {isNamesEmpty()}");
            Console.WriteLine($" Is List empty: {isListEmpty(names)}");
            Console.WriteLine($" Is List empty: {isListEmpty(empty)}");
            Console.WriteLine($" Sum {sum(2, 5)}");
            Console.WriteLine($" First is larger: {firstIsLarger(10, 3)}");
            Console.WriteLine($" First is larger: {firstIsLarger(3, 10)}");
            #endregion

            #region High Order Function use of Anonymous Methods
            Console.WriteLine("----------- Anonymous with Linq ------------");
            // We can use direct lambda expressions in high order methods in C#
            string foundBob = names.Find(x => x == "Bob");
            Console.WriteLine(foundBob);

            Func<string, bool> IsBob = x => x == "Bob";

            //string foundBobLinq = names.FirstOrDefault(x => x == "Bob");
            string foundBobLinq = names.FirstOrDefault(IsBob);
            Console.WriteLine(foundBobLinq);

            Func<string, bool> startsWithJ = x => x.StartsWith("J");
            var letterJNames = names
                                   .Where(startsWithJ)
                                   .ToList();
            letterJNames.ForEach(x => Console.WriteLine(x));
            #endregion

            Console.ReadLine();
        }
    }
}
