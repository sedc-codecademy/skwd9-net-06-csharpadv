using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, string, int> tempPerson = Tuple.Create("Bob", "Bobski", 31);

            Console.WriteLine($"Welcome {tempPerson.Item1} {tempPerson.Item2} - {tempPerson.Item3} years old!");

            Tuple<int, int> numberForSum = Tuple.Create(5, 10);

            var result = Sum(numberForSum);

            Console.WriteLine(result);


            Tuple<int, string> userIntoResult = UserInfo(5, 10, "Viktor");
            Console.WriteLine(userIntoResult.Item1);
            Console.WriteLine(userIntoResult.Item2);

            Console.ReadLine();
        }

        public static int Sum(Tuple<int, int> numbers) 
        {
            return numbers.Item1 + numbers.Item2;
        }

        public static Tuple<int, string> UserInfo(int number1, int number2, string name) 
        {
            var userAge = number1 + number2;
            var nameWithPrefix = $"mr/ms {name}";

            return Tuple.Create(userAge, nameWithPrefix);
        }
    }
}
