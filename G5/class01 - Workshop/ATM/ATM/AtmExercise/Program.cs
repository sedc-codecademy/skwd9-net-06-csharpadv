using AtmExercise.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AtmExercise
{
    class Program
    {
        // this will simulate our Database 
        public static List<User> Users { get; set; }
        static void Main(string[] args)
        {
            Users = GenerateUsers();

            StartApp();

            Console.ReadLine();
        }

        public static void StartApp()
        {
            while (InitiateUserUi())
            {
                Console.Clear();
            }

            // contunie with the next part of the app

        }


        public static bool InitiateUserUi() 
        {
            Console.WriteLine("===================");
            Console.WriteLine("Welcome to SEDC ATM");
            Console.WriteLine("===================");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Register");

            int loginChoice = 0;
            bool isLoginChoiceNumber = int.TryParse(Console.ReadLine(), out loginChoice);

            if (!isLoginChoiceNumber) 
            {
                Console.WriteLine("Sorry, wrong input, please try agian...");
                Thread.Sleep(1000);
                return true;
            }

            if (loginChoice < 1 || loginChoice > 2) 
            {
                Console.WriteLine("Sorry, wrong input, please try agian...");
                Thread.Sleep(1500);
                return true;
            }

            if (loginChoice == 1) 
            {
                Login();
            }

            if (loginChoice == 2) 
            {
                Register();
            }

            return false;
        }

        public static void Login() 
        {
            Console.WriteLine("===================");
            Console.WriteLine("Login");
            Console.WriteLine("===================");

            Console.WriteLine("Enter card number");

            string cardNumber = Console.ReadLine();
            long formatedCardNumber = FormatCardNumber(cardNumber);



        }

        public static void Register() { Console.WriteLine("Register..."); }


        public static List<User> GenerateUsers() 
        {
            return new List<User>()
            {
                new User("Bob", "Bobsky", 1234123412341234, 1234, 750),
                new User("Jill","Wayne", 8235823582358235, 9000, 1200),
                new User("Rayan","Dawn", 0090119122923393, 2500, 500),
                new User("Anne","May", 0000220311012203, 0000, 400)
            };
        }

        public static long FormatCardNumber(string cardNumberString) //1234123412341234 //1234-1234-1234-1234
        {
            string[] numbers = cardNumberString.Split("-");
            long cardNumberLong = 0;

            if (numbers.Length == 1) 
            {
                if (cardNumberString.Length != 16) 
                {
                    return -1;
                }

                bool isNumber = long.TryParse(cardNumberString, out cardNumberLong);

                if (!isNumber) 
                {
                    return -1;
                }

                return cardNumberLong;
            }

            if (numbers.Length == 4) 
            {
                bool isNumber = long.TryParse(numbers[0] + numbers[1] + numbers[2] + numbers[3], out cardNumberLong);

                if (!isNumber)
                {
                    return -1;
                }

                return cardNumberLong;
            }

            return -1;
        }
    }
}
