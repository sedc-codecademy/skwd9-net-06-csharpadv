using System;
using System.Collections.Generic;
using System.Linq;
using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using SEDC.TryBeingFit.Services.Helpers;

namespace SEDC.TryBeingFit.Services.Services
{
    public class UIService : IUIService
    {
        public List<string> MainMenuItems { get; set; }
        public List<string> AccountMenuItems { get; set; }
        public int MainMenu(UserRole role)
		{
            MainMenuItems = new List<string>() { "Account", "Log Out" };
			switch (role)
			{
				case UserRole.Standard:
                    MainMenuItems.Insert(0, "Train");
                    MainMenuItems.Insert(0, "Upgrade to Premium");
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
		public int AccountMenu(UserRole role)
		{
            AccountMenuItems = new List<string>() { "Change Info", "Check Subscription", "Change Password" };
			return ChooseMenu(AccountMenuItems);
		}
        public void UpgradeToPremium()
        {
            Console.Clear();
            Console.WriteLine("Upgrade to premium to get these features:");
            Console.WriteLine("* Live trainings");
            Console.WriteLine("* Newsletter in your mail");
            Console.WriteLine("* Discounts at sports equipment stores");
            Console.ReadLine();
        }
        public int TrainMenu()
        {
            Console.Clear();
            List<string> trainingMenu = new List<string>() { "Video", "Live" };
            Console.WriteLine("Choose what type of training do you want:");
            return ChooseMenu(trainingMenu);
        }
        public int TrainMenuItems<T>(List<T> trainings) where T : Training
        {
            Console.Clear();
            Console.WriteLine("Choose a training:");
            return ChooseEntiiesMenu(trainings);

        }
        public int ChooseEntiiesMenu<T>(List<T> entities) where T : IBaseEntity
		{
            Console.Clear();
            while (true)
			{
				Console.WriteLine("Enter a number to choose one of the following:");
				for (int i = 0; i < entities.Count; i++)
				{
					Console.WriteLine($"{i + 1}) {entities[i].Print()}");
				}
				int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), entities.Count);
				if (choice == -1)
				{
					MessageHelper.Color("[Error] Input incorrect. Please try again", ConsoleColor.Red);
					Console.ReadLine();
					continue;
				}
				return choice;
			}
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
					MessageHelper.Color("[Error] Input incorrect. Please try again", ConsoleColor.Red);
					Console.ReadLine();
					continue;
				}
				return choice;
			}
		}

		public void Welcome(User user)
		{
            Console.Clear();
            Console.WriteLine($"Welcome to the fitness app {user.Username}!");
			switch (user.Role)
			{
				case UserRole.Standard:
					Console.WriteLine("If you enjoy the app, consider our Premium subscription!");
					break;
				case UserRole.Premium:
					Console.WriteLine("We are so glad you are part of our community!");
					break;
				case UserRole.Trainer:
					Console.WriteLine("We are so glad to have you as a partner!");
					break;
			}
            Console.ReadLine();
		}

		public int LogInMenu()
		{
            Console.Clear();
            List<string> menuItems = new List<string>() { "LogIn", "Register" };
			return ChooseMenu(menuItems);
		}

		public int RoleMenu()
		{
            Console.Clear();
            List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
			return ChooseMenu(menuItems);
		}

        
	}
}
