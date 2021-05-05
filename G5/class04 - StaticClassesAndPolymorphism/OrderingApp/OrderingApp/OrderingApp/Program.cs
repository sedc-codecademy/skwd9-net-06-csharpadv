using OrderingApp.Databse;
using OrderingApp.Enums;
using OrderingApp.Helpers;
using OrderingApp.Models;
using System;
using System.Linq;

namespace OrderingApp
{
    class Program
    {
        public static User activeUser;

        static void Main(string[] args)
        {
            while (true) 
            {
                // main menu
                Console.Clear();
                Console.WriteLine("Welcome to the OrderingApp menu!");

                Console.WriteLine("Choose a User:");

                OrderingApp_DB.ListUsers();

                int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine());

                if (userChoice == -1) 
                {
                    continue;
                }

                activeUser = OrderingApp_DB.Users[userChoice - 1];

                // orders menu
                Console.Clear();
                Console.WriteLine("Orders menu");
                Console.WriteLine("1) Check Order Status");
                Console.WriteLine("2) Add new Order");
                Console.WriteLine("3) Delete Order");

                int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());

                if (menuChoice == -1)
                {
                    continue;
                }

                //get orders
                if (menuChoice == 1) 
                {
                    Console.Clear();
                    
                    activeUser.PrintOrders();
                    Console.WriteLine("Enter Id to check the status:");

                    int orderId = TextHelper.ValidateNumberInput(Console.ReadLine());

                    if (orderId == -1)
                    {
                        continue;
                    }

                    OrderStatus status = activeUser.Orders.Where(order => order.Id == orderId).FirstOrDefault().Status;
                    TextHelper.GenerateStatusMessage(status);

                    Console.ReadLine();
                }

                //create order
                if (menuChoice == 2) 
                {
                    Console.Clear();
                    Order newOrder = new Order();

                    Console.WriteLine("Enter order name:");
                    newOrder.Title = Console.ReadLine();

                    Console.WriteLine("Enter order description:");
                    newOrder.Description = Console.ReadLine();

                    OrderingApp_DB.InsertOrder(activeUser.Id, newOrder);
                    Console.ReadLine();
                }

                //delete order
                if (menuChoice == 3) 
                {
                    Console.Clear();

                    activeUser.PrintOrders();

                    Console.WriteLine("Enter the ID of the order to delete it:");
                    int orderId = TextHelper.ValidateNumberInput(Console.ReadLine());

                    if (orderId == -1)
                    {
                        continue;
                    }

                    OrderingApp_DB.DeleteOrder(activeUser.Id, orderId);
                    Console.ReadLine();
                }
            }




            
        }
    }
}
