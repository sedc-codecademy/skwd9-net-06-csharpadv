using System;
using System.Collections.Generic;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Bob", "Jill", "Wayne", "Greg", "John", "Anne" };


            Func<bool> isNamesEmpty = () => names.Count == 0;
            Func<bool> isNamesEmpty2 = () => names.Count > 0;
            Func<int> isNamesEmpty3 = () => 5;

            var result = isNamesEmpty3();
            var result2 = isNamesEmpty();
            Console.WriteLine(result);
            Console.WriteLine(result2);

            Action hello = () => Console.WriteLine("Hello");
            Action<string> helloWithName = (name) => Console.WriteLine("Hello " + name);

            hello();
            helloWithName("Viktor");

            bool result3 = CheckNumbers(10, 5, (x, y) => x > y);
            bool result4 = CheckNumbers(10, 5, (x, y) => x == y);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }

        public static bool CheckNumbers(int number1, int number2, Func<int, int, bool> func) 
        {
            return func(number1, number2);
        }
    }
}
