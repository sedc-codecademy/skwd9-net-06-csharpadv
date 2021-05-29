using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Core.Entities.User;
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
        public List<string> MainMenuItems { get; set; }
        public List<string> AccountMenuItems { get; set; }

        public void Welcome(User user)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Fitness app {user.Username}");

            switch (user.Role)
            {
                case UserRole.Standard:
                    Console.WriteLine("If you enjoy our app, please consider our Premium subscribtion.");
                    break;
                case UserRole.Premium:
                    Console.WriteLine("We are glad you are part of our comunity.");
                    break;
                case UserRole.Trainer:
                    Console.WriteLine("We are glad to have you as a partner.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        public int MainMenu(UserRole role)
        {
            MainMenuItems = new List<string>() { "Account", "Log Out" };
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
                    break;
            }

            return ChooseMenu(MainMenuItems);
        }

        public int LogInMenu()
        {
            Console.Clear();
            List<string> menuItems = new List<string>() { "Login", "Register" };
            return ChooseMenu(menuItems);
        }

        public int RoleMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the following user roles:");
            List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
            return ChooseMenu(menuItems);
        }
        public int TrainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the following training options:");
            List<string> menuItems = new List<string>() { "Video", "Live" };
            return ChooseMenu(menuItems);
        }

        public int AccountMenu() 
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the following Account options:");
            AccountMenuItems = new List<string>() { "Change Info", "Check Subscription", "Change Password" };
            return ChooseMenu(AccountMenuItems);
        }

        public int TrainMenuItems<T>(List<T> trainings) where T : Training
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the following trainings:");
            return ChooseEntitiesMenu(trainings);
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

        public int ChooseEntitiesMenu<T>(List<T> entites) where T : BaseEntity 
        {
            Console.Clear();

            while (true) 
            {
                Console.WriteLine("Enter a number to choose one of the following: ");

                for (int i = 0; i < entites.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {entites[i].Print()}");
                }

                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), entites.Count);

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
