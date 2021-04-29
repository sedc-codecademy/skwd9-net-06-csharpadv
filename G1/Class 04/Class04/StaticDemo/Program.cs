using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextHelper.Text);

            int number = TextHelper.ConvertStringToInt(Console.ReadLine());
            Console.WriteLine($"The number you have entered is: {number}");

            TextHelper.Text = "Something else";
            Console.WriteLine(TextHelper.Text);

            Console.WriteLine(Human.SayHi("Risto"));

            Human test = new Human("Risto", "Panchevski");
            Console.WriteLine($"{test.FirstName} {test.LastName}");
        }
    }
}
