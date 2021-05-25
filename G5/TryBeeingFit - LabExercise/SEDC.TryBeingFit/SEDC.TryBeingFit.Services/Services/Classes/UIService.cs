using SEDC.TryBeingFit.Domain.Core.Enum;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Classes
{
    public class UIService : IUIService
    {
        
        public int LogInMenu()
        {
            Console.Clear();
            List<string> menuItems = new List<string>() { "Login", "Register" };
            return ChooseMenu(menuItems);
        }

        public int RoleMenu()
        {
            Console.Clear();
            List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
            return ChooseMenu(menuItems);
        }

        public int ChooseMenu<T>(List<T> items)
        {
            Console.Clear();
            while (true) 
            {
                Console.WriteLine("Enter a number to choose one of the following:");

                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {items[i]}");
                }

                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);

                if (choice == -1) 
                {
                    MessageHelper.Color("[Error] Incorrect input. Please try again", ConsoleColor.Red);
                    Console.ReadLine();
                    continue;
                }

                return choice;
            }
        }

      
    }
}
