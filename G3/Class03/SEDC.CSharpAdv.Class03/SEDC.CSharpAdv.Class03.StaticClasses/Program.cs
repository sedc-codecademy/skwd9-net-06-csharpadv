using SEDC.CSharpAdv.Class03.StaticClasses.Entities;
using SEDC.CSharpAdv.Class03.StaticClasses.Helpers;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class03.StaticClasses
{
    class Program
    {
        static User _currentUser;

        static void Main(string[] args)
        {
            while (true)
            {
                // ctrl - k + f
                // Main menu

                Console.WriteLine("Welcome to the ordering menu");
                if (TextHelper.MessageGenerated != 0)
                {
                    Console.WriteLine($"Fun fact: People checked their order status {TextHelper.MessageGenerated} times");
                }
                Console.WriteLine("Choose a User:");
                OrdersTempDb.ListUsers();
                int userChoise = TextHelper.ValidateNumberInput(Console.ReadLine());
                if (userChoise == -1)
                {
                    continue;
                }
                _currentUser = OrdersTempDb.Users[userChoise - 1];

                Console.Clear();
                OrderMenu();
                int menuChoise = TextHelper.ValidateNumberInput(Console.ReadLine());
                if(menuChoise == -1)
                {
                    continue;
                }

                if(menuChoise == 1)
                {
                    CheckOrders();
                } 
                else if(menuChoise == 2)
                {
                    AddNewOreder();
                }

                Console.ReadLine();
            }
        }

        static void OrderMenu()
        {
            Console.WriteLine("Orders Menu:");
            Console.WriteLine("1) Check Orders");
            Console.WriteLine("2) Add new Order");
        }

        static void CheckOrders()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose one order to check status");
                _currentUser.PrintOrders();
                int orderChoise = TextHelper.ValidateNumberInput(Console.ReadLine());
                if (orderChoise == -1)
                {
                    continue;
                }
                Order order = _currentUser.Orders[orderChoise - 1];
                Order.GenerateStatusMessage(order);
                break;
            }
        }

        static void AddNewOreder()
        {
            Console.Clear();
            Order order = new Order();
            Console.WriteLine("Enter order name");
            string title = Console.ReadLine();
            Console.WriteLine("Enter description");
            string desc = Console.ReadLine();
            order.Title = title;
            order.Description = desc;
            OrdersTempDb.InsertOrder(_currentUser.Id, order);
        }
    }
}
