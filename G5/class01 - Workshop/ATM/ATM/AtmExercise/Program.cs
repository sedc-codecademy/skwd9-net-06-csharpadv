using AtmExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AtmExercise
{
    class Program
    {
        // this will simulate our Database 
        public static List<User> Users { get; set; }
        public static User LoggedUser { get; set; }
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

            Console.WriteLine("Welcome to ATM");
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
                Thread.Sleep(1500);
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
            Console.Clear();

            Console.WriteLine("===================");
            Console.WriteLine("Login");
            Console.WriteLine("===================");

            Console.WriteLine("Enter card number:");
            string cardNumber = Console.ReadLine();
            long formatedCardNumber = FormatCardNumber(cardNumber);

            if (formatedCardNumber == -1) 
            {
                Console.WriteLine("Sorry, invalid card number, please try agian...");
                Thread.Sleep(1500);
                Console.Clear();
                Login();
                return;
            }

            Console.WriteLine("Enter Pin:");

            short pinShort = 0;
            string pinString = Console.ReadLine();
            bool pin = short.TryParse(pinString, out pinShort);

            if (!pin || pinString.Length != 4) 
            {
                Console.WriteLine("Sorry, invalid pin, please try agian...");
                Thread.Sleep(1500);
                Console.Clear();
                Login();
                return;
            }

            LoggedUser = Users.Where(user => user.CardNumber == formatedCardNumber && user.CheckPin(pinShort)).FirstOrDefault();

            if (LoggedUser == null) 
            {
                Console.WriteLine("Sorry, user with this credentals does not exist, please try agian, or register new account.");
                Thread.Sleep(1500);
                Console.Clear();
                StartApp();
                return;
            }

        }

        public static void Register() 
        {
            Console.Clear();

            Console.WriteLine("===================");
            Console.WriteLine("Register");
            Console.WriteLine("===================");

            Console.WriteLine("Enter card number:");
            string cardNumber = Console.ReadLine();
            long formatedCardNumber = FormatCardNumber(cardNumber);

            if (formatedCardNumber == -1)
            {
                Console.WriteLine("Sorry, invalid card number, please try agian...");
                Thread.Sleep(1500);
                Console.Clear();
                Register();
                return;
            }

            Users.ForEach(user =>
            {
                if (formatedCardNumber == user.CardNumber) 
                {
                    Console.WriteLine("Sorry, the card number already exists, please try agian...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Register();
                    return;
                }
            });

            Console.WriteLine("Enter Pin:");

            short pinShort = 0;
            string pinString = Console.ReadLine();
            bool pin = short.TryParse(pinString, out pinShort);

            if (!pin || pinString.Length != 4)
            {
                Console.WriteLine("Sorry, invalid pin, please try agian...");
                Thread.Sleep(1500);
                Console.Clear();
                Register();
                return;
            }

            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your Balance: ");
            int balance = 0;
            bool isBalanceNumber = int.TryParse(Console.ReadLine(), out balance);

            if (!isBalanceNumber) 
            {
                Console.WriteLine("Sorry, invalid balance, please try agian...");
                Thread.Sleep(1500);
                Console.Clear();
                Register();
                return;
            }

            User newUser = new User(firstName, lastName, formatedCardNumber, pinShort, balance);
            Users.Add(newUser);

            Console.WriteLine($"{newUser.GetFullName()} has been succssfully registered!");
            LoggedUser = newUser;
        }


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
