﻿using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Core.Entities.User;
using SEDC.TryBeingFit.Domain.Core.Enum;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Services.Classes;
using SEDC.TryBeingFit.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SEDC.TryBeingFit.App
{
    class Program
    {
        public static IUIService _uiService = new UIService();

        public static IUserService<StandardUser> _standardUserService = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserService = new UserService<PremiumUser>();
        public static IUserService<TrainerUser> _trainerUserService = new UserService<TrainerUser>();

        public static ITrainingService<VideoTraining> _videoTrainingService = new TrainingService<VideoTraining>();
        public static ITrainingService<LiveTraining> _liveTrainingService = new TrainingService<LiveTraining>();

        public static User _currentUser;

        public static void Seed() 
        {
            if (_standardUserService.IsDbEmpty() &&
                _premiumUserService.IsDbEmpty() &&
                _trainerUserService.IsDbEmpty() &&
                _videoTrainingService.IsDbEmpty() &&
                _liveTrainingService.IsDbEmpty())
            {
                _standardUserService.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
                _premiumUserService.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jilllw", Password = "jillsuper26" });

                TrainerUser John = new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55", YearsOfExperience = 7 };
                _trainerUserService.Register(John);

                _videoTrainingService.AddTraining(new VideoTraining() { Title = "30 min workout", Description = "Cool workout for beginners and intermediate users", Difficulty = Difficulty.Medium, Link = "https://www.youtube.com/watch?v=50kH47ZztHs", Rating = 4, Time = 35 });
                _videoTrainingService.AddTraining(new VideoTraining() { Title = "Standing ABS workout", Description = "Abs workout for people at home with standing and no equipment required", Difficulty = Difficulty.Easy, Link = "https://www.youtube.com/watch?v=Qia2ZXEzyLw", Rating = 5, Time = 11 });
                _videoTrainingService.AddTraining(new VideoTraining() { Title = "Full AGILITY Bodyweight", Description = "An intense workout for people that have experience working out and need a good AGILITY training", Difficulty = Difficulty.Hard, Link = "https://www.youtube.com/watch?v=tveIjnSG_8s", Rating = 2, Time = 67 });

                _liveTrainingService.AddTraining(new LiveTraining() { Title = "Workout with John", Description = "Working out can be easy when you are at home. Trust John, he is a professional!", Difficulty = Difficulty.Medium, NextSession = new DateTime(2021, 07, 20), Trainer = John, Rating = 2, Time = 25 });
                _liveTrainingService.AddTraining(new LiveTraining() { Title = "Quick abs with John", Description = "You want abs for the summer? You want them quick? This is the training for you!", Difficulty = Difficulty.Hard, NextSession = new DateTime(2021, 07, 24), Trainer = John, Rating = 4, Time = 40 });
            }
        }

        static void Main(string[] args)
        {
            Seed();

            while (true) 
            {
                //login/register
                if (_currentUser == null) 
                {
                    int loginChoice = _uiService.LogInMenu();

                    //login
                    if (loginChoice == 1) 
                    {
                        int roleChoice = _uiService.RoleMenu();
                        UserRole role = (UserRole)roleChoice;
                        Console.Clear();

                        Console.WriteLine("Enter Username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter Password:");
                        string password = Console.ReadLine();

                        switch (role)
                        {
                            case UserRole.Standard:
                                _currentUser = _standardUserService.Login(username, password);
                                break;
                            case UserRole.Premium:
                                _currentUser = _premiumUserService.Login(username, password);
                                break;
                            case UserRole.Trainer:
                                _currentUser = _trainerUserService.Login(username, password);
                                break;        
                        }

                        if (_currentUser == null) continue;
                    }

                    //register
                    if (loginChoice == 2) 
                    {
                        StandardUser newUser = new StandardUser();

                        Console.WriteLine("Enter First Name:");
                        newUser.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        newUser.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Username:");
                        newUser.Username = Console.ReadLine();
                        Console.WriteLine("Enter Password:");
                        newUser.Password = Console.ReadLine();

                        if (_currentUser == null) 
                        {
                            User user = _standardUserService.Register(newUser);
                            if (user == null) continue;
                            _currentUser = user;
                        }
                    }

                    _uiService.Welcome(_currentUser);
                }

                //main menu
                int mainMenuChoice = _uiService.MainMenu(_currentUser.Role);
                string mainMenuItem = _uiService.MainMenuItems[mainMenuChoice - 1];

                switch (mainMenuItem)
                {
                    case "Train":

                        //int trainChoice;

                        //if (_currentUser.Role == UserRole.Premium)
                        //{
                        //    trainChoice = _uiService.TrainMenu();
                        //}
                        //else 
                        //{
                        //    trainChoice = 1;
                        //}

                        int trainChoice = _currentUser.Role == UserRole.Premium ? _uiService.TrainMenu() : 1;

                        //video training
                        if (trainChoice == 1) 
                        {
                            int trainingItem = _uiService.TrainMenuItems(_videoTrainingService.GetTrainings());
                            VideoTraining training = _videoTrainingService.GetTrainingByIndex(trainingItem - 1);
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"Link: {training.Link}");
                            Console.WriteLine($"Raiting: {training.Rating}");
                            Console.WriteLine($"Time: {training.Time} minutes");
                            Console.ReadLine();
                        }

                        //live training
                        if (trainChoice == 2) 
                        {
                            int trainingItem = _uiService.TrainMenuItems(_liveTrainingService.GetTrainings());
                            LiveTraining training = _liveTrainingService.GetTrainingByIndex(trainingItem - 1);
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"The training starts at: {training.NextSession}");
                            Console.WriteLine($"Raiting: {training.Rating}");
                            Console.WriteLine($"Time: {training.Time} minutes");
                            Console.ReadLine();
                        }

                        break;
                    case "Upgrade to premium":

                        //suggestion for implementing real UpgradeToPremium functionality

                        // logout 
                        // keep the currently logged user in a variable
                        // find and delete that user from standardUserService
                        // regsiter new premium user in the premiumUserService with the same data
                        // log in the newly registered user

                        Console.Clear();
                        Console.WriteLine("Do you really want to upgrade to premium? It will cost you 15$.");
                        Console.WriteLine("Press enter to upgrade!");

                        Console.ReadLine();

                        User tempCurrentUser = _currentUser;
                        _currentUser = null;
                        _standardUserService.DeleteById(tempCurrentUser.Id);
                        PremiumUser newUser = _premiumUserService.MapToPremiumUser(tempCurrentUser);
                        User user = _premiumUserService.Register(newUser);
                        _currentUser = user;

                        Console.WriteLine("Createing new premium sibscription, please wait ....");
                        Thread.Sleep(2000);

                        Console.WriteLine($"You have succesfully buy a premium subscription. Welcome back {_currentUser.Username}.");
                        Thread.Sleep(2000);

                        Console.ReadLine();
                        break;
                    case "Reschedule training":
                        List<LiveTraining> trainings = _liveTrainingService.GetTrainings().Where(training => training.Trainer.Id == _currentUser.Id).ToList();
                        if (trainings.Count == 0)
                        {
                            Console.WriteLine("No available trainings.");
                            Console.ReadLine();
                        }
                        else 
                        {
                            int trainingChoice = _uiService.ChooseEntitiesMenu(trainings);
                            Console.WriteLine("How many days fo you want to reschedule the training: ");
                            int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 10);
                            _trainerUserService.GetById(_currentUser.Id).ChangeSchedule(trainings[trainingChoice - 1], days);
                            Console.WriteLine("Schadule changed!");
                            Console.ReadLine();
                        }
                        break;
                    case "Account":
                        int accountChoice = _uiService.AccountMenu();
                        Console.Clear();
                        if (accountChoice == 1)
                        {
                            //Change Info
                            Console.WriteLine("Enter First Name:");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name:");
                            string lastName = Console.ReadLine();

                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
                                    _standardUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Premium:
                                    _premiumUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Trainer:
                                    _trainerUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (accountChoice == 2)
                        {
                            //Check Subscription
                            Console.WriteLine($"Your subscription is {_currentUser.Role}");
                            Console.ReadLine();
                        }
                        else if (accountChoice == 3) 
                        {
                            //Change Password 
                            Console.WriteLine("Enter Old Password:");
                            string oldPassword = Console.ReadLine();
                            Console.WriteLine("Enter New Password:");
                            string newPassword = Console.ReadLine();

                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
                                    _standardUserService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                                    break;
                                case UserRole.Premium:
                                    _premiumUserService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                                    break;
                                case UserRole.Trainer:
                                    _trainerUserService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "Log Out":
                        _currentUser = null;
                        break;
                    default:
                        break;
                }
            }
        }


    }
}
