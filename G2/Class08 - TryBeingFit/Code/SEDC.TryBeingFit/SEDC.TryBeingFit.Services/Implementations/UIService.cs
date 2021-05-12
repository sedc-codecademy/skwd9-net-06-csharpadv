using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class UIService : IUIService
    {
        public int ChooseMenuItem(List<string> menuItems)
        {
            while (true)
            {
                
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menuItems[i]}");
                }
                string input = Console.ReadLine();
                int choice = ValidationHelper.ValidateNumber(input, menuItems.Count);
                if (choice == -1)
                {
                    MessageHelper.PrintMessage("You must enter a valid option", ConsoleColor.Red);
                   
                    continue;
                }
                return choice;
            }

        }

        public int LogInMenu()
        {
            List<string> menuItems = new List<string> { "LogIn", "Register" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int RoleMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList(); //gets the names of members of UserRole enum
            Console.WriteLine("Choose role");
            return ChooseMenuItem(menuItems);
        }
    }
}
