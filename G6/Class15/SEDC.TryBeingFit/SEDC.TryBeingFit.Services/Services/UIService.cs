using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using SEDC.TryBeingFit.Domain.Core.Models;
using SEDC.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public class UIService : IUIService
    {
        public List<string> AccountMenuItems { get; set; }
        public List<string> MainMenuItems { get; set; }

        public int ChooseMenu<T>(List<T> items)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{ i + 1 } { items[i] }");
                }
                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);
                if (choice == -1)
                {
                    MessageHelper.PrintMessage("[Error] Input incorrect. Please try again!", ConsoleColor.Red);
                    Console.ReadLine();
                    continue;
                }
                return choice;
            }
        }

        public int MainMenu(UserRole role)
        {
            MainMenuItems = new List<string> { "Account", "Log out" };
            switch (role)
            {
                case UserRole.Standard:
                    MainMenuItems.Insert(0, "Train");
                    MainMenuItems.Insert(0, "Upgrade to premium");
                    break;
                case UserRole.Premium:
                    MainMenuItems.Insert(0, "Train");
                    break;
                case UserRole.Trainer:
                    MainMenuItems.Insert(0, "Reschedule training");
                    MainMenuItems.Insert(0, "Start new training");
                    break;
                default:
                    break;
            }
            return ChooseMenu(MainMenuItems);
        }

        public int AccountMenu(UserRole role)
        {
            AccountMenuItems = new List<string> { "Change info", "Check Subscription", "Change Password" };
            return ChooseMenu(AccountMenuItems);
        }

        public int LoginMenu()
        {
            Console.Clear();
            List<string> menuItems = new List<string> { "LogIn", "Register" };
            return ChooseMenu(menuItems);
        }

        public int RoleMenu()
        {
            Console.Clear();
            List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
            return ChooseMenu(menuItems);
        }

        public int TrainMenu()
        {
            Console.Clear();
            List<string> menuItems = new List<string> { "Video training", "Live training" };
            return ChooseMenu(menuItems);
        }

        public void Welcome(User user)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the fitness app { user.UserName }");
            switch (user.Role)
            {
                case UserRole.Standard:
                    Console.WriteLine("If you enjoy the app, consider our Premium subscription");
                    break;
                case UserRole.Premium:
                    Console.WriteLine("We are so glad you are part of our community!");
                    break;
                case UserRole.Trainer:
                    Console.WriteLine("We are so glad to have you as a partner!");
                    break;
                default:
                    break;
            }
        }

        public int ChooseEntititesMenu<T>(List<T> entities) where T : IBaseEntity
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < entities.Count; i++)
                {
                    Console.WriteLine($"{ i + 1 } { entities[i].Print() }");
                }
                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), entities.Count);
                if (choice == -1)
                {
                    MessageHelper.PrintMessage("[Error] Input incorrect. Please try again!", ConsoleColor.Red);
                    Console.ReadLine();
                    continue;
                }
                return choice;
            }
        }

        public int TrainMenuItems<T>(List<T> items) where T : Training
        {
            Console.Clear();
            return ChooseEntititesMenu(items);
        }


        public void UpgradeToPremium()
        {
            Console.Clear();
            Console.WriteLine("Upgrade to premium to get these features:");
            Console.WriteLine("* Live trainings");
            Console.WriteLine("* Newsletter in your mail box");
            Console.WriteLine("* Discounts at sports equipment stores");
        }

    }
}
