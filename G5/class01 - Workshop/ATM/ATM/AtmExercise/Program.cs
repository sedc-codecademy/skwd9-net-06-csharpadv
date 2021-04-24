using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AtmExercise.Entities.Models;
using AtmExercise.InMemoryDatabase;

namespace AtmExercise
{
    class Program
    {
        public static Customer LoggedCustomer { get; set; }
        static void Main(string[] args)
        {
            StartApp();
            Console.ReadLine();
        }

        public static void StartApp()
        {
            while (InitiateUserUi())
            {
                Console.Clear();
            }

            StartAtm();
        }

        public static void StartAtm() 
        {
            int operation = InitiateAtmUi();
            StartAtmServices(operation);
        }

        public static void StartAtmServices(int choice) 
        {
            switch (choice)
            {
                case 1:
                    CheckBalance();
                    break;
                case 2:
                    CashWithdrawal();
                    break;
                case 3:
                    CashDeposit();
                    break;
                case 4:
                    CashTransfer();
                    break;
                case 5:
                    Logout();
                    break;
                default:
                    break;
            }

            while (true) 
            {
                Console.WriteLine("Do you want another service?");
                Console.WriteLine("Type YES of you want to continue");
                Console.WriteLine("Type NO of you want to Logout");
                Console.WriteLine("YES/NO");

                string endChoice = Console.ReadLine();

                if (endChoice.ToUpper() == "YES") 
                {
                    StartAtm();
                    break;
                }

                if (endChoice.ToUpper() == "NO")
                {
                    Logout();
                    break;
                }

                Console.WriteLine("Invalid input");
                Thread.Sleep(1500);
            }
        }

        public static void CheckBalance() 
        {
            Console.Clear();

            Console.WriteLine("===================");
            Console.WriteLine($"{LoggedCustomer.GetFullName()}, your currnet blance is {LoggedCustomer.GetUserBalance()}");
            Console.WriteLine("===================");
        }

        public static void CashWithdrawal() 
        {
            Console.Clear();

            Console.WriteLine("===================");
            Console.WriteLine($"Cash Withdrawal");
            Console.WriteLine("===================");

            Console.WriteLine($"{LoggedCustomer.GetFullName()}, how much money do you want to withdraw?");

            int ammount = 0;
            bool isAmmountNumber = int.TryParse(Console.ReadLine(), out ammount);

            if (!isAmmountNumber)
            {
                Console.WriteLine("Invalid ammount...");
                Thread.Sleep(1500);
                CashWithdrawal();
            }

            bool isTransactionSuccessfull = LoggedCustomer.WithdrawFromAccount(ammount);

            if (isTransactionSuccessfull)
            {
                Console.WriteLine($"Please get your money...");
                Thread.Sleep(1500);
                CheckBalance();
            }
            else 
            {
                Console.WriteLine($"Sorry, you don't have enough money for the transaction.");
                Thread.Sleep(1500);
                CheckBalance();
            }

        }

        public static void CashDeposit() 
        {
            Console.Clear();

            Console.WriteLine("===================");
            Console.WriteLine($"Cash Deposit");
            Console.WriteLine("===================");

            Console.WriteLine($"{LoggedCustomer.GetFullName()}, how much money do you want to deposit?");

            int ammount = 0;
            bool isAmmountNumber = int.TryParse(Console.ReadLine(), out ammount);

            if (!isAmmountNumber)
            {
                Console.WriteLine("Invalid ammount...");
                Thread.Sleep(1500);
                CashDeposit();
            }

            bool isTransactionSuccessfull = LoggedCustomer.DepositMoneyToAccount(ammount);

            if (isTransactionSuccessfull)
            {
                Console.WriteLine($"Please deposit your money...");
                Thread.Sleep(1500);
                CheckBalance();
            }
            else
            {
                Console.WriteLine($"Sorry, invalid ammount...");
                Thread.Sleep(1500);
                CheckBalance();
            }
        }
        public static void CashTransfer() 
        {
            Console.Clear();

            Console.WriteLine("===================");
            Console.WriteLine($"Cash Transfer");
            Console.WriteLine("===================");

            Console.WriteLine($"{LoggedCustomer.GetFullName()}, please enter the card number that you want to transfer money to?");

            string cardNumber = Console.ReadLine();
            long formatedCardNumber = FormatCardNumber(cardNumber);

            if (formatedCardNumber == -1)
            {
                Console.WriteLine("Sorry, invalid card number, please try agian...");
                Thread.Sleep(1500);
                CashTransfer();
                return;
            }

            Customer customerForTransfer = ATM_DB.Users.Where(customer => customer.CardNumber == formatedCardNumber).FirstOrDefault();

            if (customerForTransfer == null) 
            {
                Console.WriteLine("Sorry, this credit card number does not exist.");
                Thread.Sleep(1500);
                CashTransfer();
                return;
            }

            Console.WriteLine($"{LoggedCustomer.GetFullName()}, how much money do you want to transfer to {customerForTransfer.GetFullName()}?");

            int amount = 0;
            bool isAmmountNumber = int.TryParse(Console.ReadLine(), out amount);

            if (!isAmmountNumber)
            {
                Console.WriteLine("Invalid ammount...");
                Thread.Sleep(1500);
                CashTransfer();
            }

            //if (amount > LoggedUser.GetUserBalance()) 
            //{
            //    Console.WriteLine("Sorry, you dont have enough money.");
            //    Thread.Sleep(1500);
            //    CashTransfer();
            //}

            bool isWithdrawSuccessfull = LoggedCustomer.WithdrawFromAccount(amount);
            if (!isWithdrawSuccessfull)
            {
                Console.WriteLine("Sorry, you dont have enough money.");
                Thread.Sleep(1500);
                CashTransfer();
            }

            customerForTransfer.DepositMoneyToAccount(amount);
            Console.WriteLine("Transfering money...");
            Thread.Sleep(2000);
            Console.WriteLine($"{LoggedCustomer.GetFullName()}, you have succesfully transfered {amount}$ to {customerForTransfer.GetFullName()}");
            Thread.Sleep(2000);
            CheckBalance();
        }

        public static void Logout() 
        {
            LoggedCustomer = null;
            Console.WriteLine("Logging out...");
            Thread.Sleep(2000);
            Console.Clear();
            StartApp();
            return;
        }

        public static int InitiateAtmUi() 
        {
            Console.Clear();

            Console.WriteLine("===================");
            Console.WriteLine($"Welcome {LoggedCustomer.GetFullName()}");
            Console.WriteLine("===================");
            Console.WriteLine("1) Check Balance");
            Console.WriteLine("2) Cash Withdrawal");
            Console.WriteLine("3) Cash Deposit");
            Console.WriteLine("4) Cash Transfer");
            Console.WriteLine("5) Logout");

            int choice = 0;
            bool isChoiceNumber = int.TryParse(Console.ReadLine(), out choice);

            if (!isChoiceNumber) 
            {
                Console.WriteLine("Input needs to be a number, please try agian...");
                Thread.Sleep(1500);
                InitiateAtmUi();
                return -1;
            }

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Input is not valid, please try agian...");
                Thread.Sleep(1500);
                InitiateAtmUi();
                return -1;
            }

            return choice;
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

            LoggedCustomer = ATM_DB.Users.Where(user => user.CardNumber == formatedCardNumber && user.CheckPin(pinShort)).FirstOrDefault();

            if (LoggedCustomer == null) 
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

            ATM_DB.Users.ForEach(user =>
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

            Customer newUser = new Customer(firstName, lastName, formatedCardNumber, pinShort, balance);
            ATM_DB.Users.Add(newUser);

            Console.WriteLine($"{newUser.GetFullName()} has been succssfully registered!");
            LoggedCustomer = newUser;
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
