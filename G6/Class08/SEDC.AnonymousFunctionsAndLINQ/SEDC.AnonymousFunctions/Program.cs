using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.AnonymousFunctions
{
    class Program
    {
        public static void CheckResult(int num1, int num2, Func<int, int, int> func)
        {
            int result = func(num1, num2);
            Console.WriteLine("The result is {0}", result > 0 ? result.ToString() : "less than zero");
            //if (result > 0)
            //{
            //    Console.WriteLine("The result is: " + result);
            //}else
            //{
            //    Console.WriteLine("The result is less than 0!");
            //}
        }


        static void Main(string[] args)
        {
            #region Lambda expression

            List<string> names = new List<string> { "Martin", "Petre", "Ivo", "Dejan" };
            List<string> emptyList = new List<string>();

            string dejan = names.Find(x => x == "Dejan");
            Console.WriteLine(dejan);
            #endregion

            #region Func
            // Func always returns a value

            // Example of Func with no input parameters
            Func<bool> isPresent = () =>
            {
                return names.Any(x => x == "Martin");
            };
            Func<bool> isFound = () => names.Any(x => x == "Ivo");

            Console.WriteLine(isPresent());

            if(isFound())
            {
                Console.WriteLine("Hello there Ivo!");
            }

            // Example of Func with input parameters
            Func<int, int, int> sum = (x, y) => x + y;
            Func<int, int, int> multiply = (x, y) => x * y;

            Console.WriteLine(sum(10, 20));
            Console.WriteLine(multiply(6, 5));

            Func<List<string>, bool> isListEmpty = (list) => list.Count() == 0;

            if (isListEmpty(names))
            {
                Console.WriteLine("List of names is empty!");
            }
            else if(isListEmpty(emptyList))
            {
                Console.WriteLine("Empty list of course is empty!");
            }


            //Func<int, int, int, int> findMax = (x, y, z) =>
            //{
            //    if (x > y && x > z)
            //    {
            //        return x;
            //    }
            //    else if (y > x && y > z)
            //    {
            //        return y;
            //    }
            //    else
            //    {
            //        return z;
            //    }
            //};

            // The same method in one line of code 
            Func<int, int, int, int> findMax = (x, y, z) => new List<int> { x, y, z }.Max();
            Console.WriteLine("The max value is: ");
            Console.WriteLine(findMax(10, 100, 13));
            #endregion

            #region Action
            // Example of Action with no input paramters

            Action sayHi = () => Console.WriteLine("Hi there!");
            sayHi();

            // Example of Action with one or more input paramters
            Action<string> printRed = x =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x);
                Console.ResetColor();
            };
            printRed("Ooops! Something went wrong!");

            //int a = 10;
            Action<string, ConsoleColor> printMessage = (message, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                // The value of any variable from the parent scope can be changed inside the anonymous function
                //a++;
                //Console.WriteLine(a);
                Console.ResetColor();
            };
            printMessage("This is a warning message", ConsoleColor.Yellow);
            printMessage("This is an error message", ConsoleColor.Red);
            #endregion


            #region Func and Action used as callbacks
            Func<float, float, float> divide = (x, y) => x / y;

            CheckResult(10, 15, sum);
            CheckResult(22, 11, multiply);
            //CheckResult(20, 10, divide); this will not work for the current CheckResult declaration
            #endregion

            #region Higher order function use

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 12, 22, 100 };
            List<string> animals = new List<string> { "Elephant", "Lion", "Monkey", "Eagle", "Snake" };

            //List<int> greaterThanTen = numbers.Where(x => x > 10).ToList();

            Func<int, bool> isGreaterThanTen = x => x > 10;
            List<int> greaterThanTen = numbers.Where(isGreaterThanTen).ToList();

            Func<string, bool> foundLion = animal => animal == "Lion";
            string lion = animals.Where(foundLion).FirstOrDefault();

            bool isThereAnyLion = animals.Any(foundLion);

            if (isThereAnyLion)
            {
                Console.WriteLine("Woohooo! Lion found!");
            }
            else
            {
                Console.WriteLine("Try again nex time!");
            }

            #endregion



            Console.ReadLine();
        }
    }
}
