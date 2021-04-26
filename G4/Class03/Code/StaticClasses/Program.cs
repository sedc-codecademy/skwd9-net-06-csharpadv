using StaticClasses.Entities;
using System;

namespace StaticClasses
{
    class Program
    {
        static User _currentUser;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // we cannot instantiate object from a static class
            //var staticObject = new TextHelper();

            while (true)
            {
                #region Main Menu
                Console.Clear();
                Console.WriteLine("Welcome to the ordering menu!");
                if (TextHelper.MessagesGenerated != 0) Console.WriteLine($"Fun fact: People checked their order status {TextHelper.MessagesGenerated} times!");

                Console.WriteLine("Choose a user:");
                OrdersTempDB.ListUsers();

                int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                if (userChoice == -1) continue;

                _currentUser = OrdersTempDB.Users[userChoice - 1];
                #endregion

                #region Orders Menu
                Console.Clear();
                Console.WriteLine("Orders menu");
                Console.WriteLine("1) Check order");
                Console.WriteLine("2) Add new Orders");
                int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());

                if (menuChoice == -1) continue;

                if(menuChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Choose one to check the status");
                    _currentUser.PrintOrders();
                    int orderChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                    if (orderChoice == -1) continue;
                    TextHelper.GenerateStatusMessage(_currentUser.Orders[orderChoice - 1].Status);
                    Console.ReadLine();
                }
                else if(menuChoice == 2)
                {
                    Console.Clear();
                    Order newOrder = new Order();
                    Console.WriteLine("Enter order name:");
                    newOrder.Title = Console.ReadLine();
                    Console.WriteLine("Enter description");
                    newOrder.Description = Console.ReadLine();

                    OrdersTempDB.InsertOrder(_currentUser.Id, newOrder);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No such option");
                    Console.ReadLine();
                }
                #endregion

                User newUser = new User(55, "pero123", "Ulica Temnica");
                // we cannot use the static member
                // newUser.SayHello()
                //User.SayHello();
            }

        }
    }
}
