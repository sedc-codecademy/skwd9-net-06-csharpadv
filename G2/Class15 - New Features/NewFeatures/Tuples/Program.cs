using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(Tuple.Create(3, 4)));
            Console.WriteLine(Sum(new Tuple<int, int>(13, 2)));

            var result = Calculate(8, 6);
            Console.WriteLine(result.sum);
            Console.WriteLine(result.subtraction);

            Console.ReadLine();
        }

        public static int Sum(Tuple<int, int> numbers)
        {
            return numbers.Item1 + numbers.Item2;
        }

        public static (int sum, int subtraction) Calculate(int n1, int n2)
        {
            return (n1 + n2, n1 - n2);
        }
    }
}
