using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.Add(5, 10);
            Console.WriteLine(result);

            var result2 = Calculator.Sum(5, 10);

            Console.WriteLine(Calculator.PI);



            //Static members

            var user1 = new User()
            {
                FirstName = "Viktor",
                LastName = "Jakovlev"
            };

            user1.PrintFullName();

            var user2 = new User()
            {
                FirstName = "Angela",
                LastName = "Kostadinova"
            };

            user2.PrintFullName();

            User.Greetings(user1);
        }
    }
}
