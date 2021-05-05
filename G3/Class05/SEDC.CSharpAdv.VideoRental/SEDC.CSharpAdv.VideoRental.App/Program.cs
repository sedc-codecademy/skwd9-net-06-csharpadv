using SEDC.CSharpAdv.VideoRental.Data.Models;
using SEDC.CSharpAdv.VideoRental.Services.Helpers;
using SEDC.CSharpAdv.VideoRental.Services.Interfaces;
using SEDC.CSharpAdv.VideoRental.Services.Menus;
using SEDC.CSharpAdv.VideoRental.Services.Services;
using System;

namespace SEDC.CSharpAdv.VideoRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = null;

            IUserService userService = new UserService();

            Screen.HomeScreen();
            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                Screen.StartMenu();
                int startMenuInput = InputParser.ToInteger(1, 3);
                switch(startMenuInput)
                {
                    case 1:
                        user = userService.Login();
                        break;
                    case 2:
                        user = userService.SignUp();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
