using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class15.Tuples
{
    class Program
    {
        public static int Sum(Tuple<int, int> numbers)
        {
            return numbers.Item1 + numbers.Item2;
        }

        public static Tuple<string, bool> ReturnPackedParams(string p1, bool p2)
        {
            // here we will have some logic
            return Tuple.Create(p1, p2);
        }

        public static Tuple<string, int, long, bool, Pair<int, string>, Student, List<int>> GetTuple()
        {
            string name = "Trajan";
            int a = 10;
            long b = 1234567890;
            bool isValid = false;
            Pair<int, string> pair = new Pair<int, string> { Item1 = 3, Item2 = "this is a string" };
            Student student = new Student { Name = "Student name" };
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            return Tuple.Create(name, a, b, isValid, pair, student, list);
        }

        static void Main(string[] args)
        {
            Tuple<int, int> sumNumbers = Tuple.Create(3, 5);

            int sum = Sum(sumNumbers);
            Console.WriteLine($"{sumNumbers.Item1} + {sumNumbers.Item2} = {sum}");

            var result = ReturnPackedParams("Trajan", false);
            Console.WriteLine($"{result.Item1} {result.Item2}");

            var result1 = GetTuple();
            var (name, a, b, isValid, pair, student, list) = GetTuple();

            Console.WriteLine(result1.Item4);
            Console.WriteLine(isValid);

            Console.WriteLine(result1.Item1);
            Console.WriteLine(name);
            Console.WriteLine(result1.Item2);
            Console.WriteLine(a);
            Console.WriteLine(result1.Item3);
            Console.WriteLine(b);
            Console.WriteLine(result1.Item5);
            Console.WriteLine(pair.Item1 + pair.Item2);
            Console.WriteLine(result1.Item6);
            Console.WriteLine(student.Name);
            Console.WriteLine(result1.Item7);
            Console.WriteLine(list[0]);

            Console.ReadLine();
        }

        public class Pair<T, H>
        {
            public T Item1 { get; set; }
            public H Item2 { get; set; }
        }

        public class Student
        {
            public string Name { get; set; }
        }
    }
}
