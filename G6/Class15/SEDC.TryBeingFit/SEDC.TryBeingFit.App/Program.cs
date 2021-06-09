using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.TryBeingFit.App
{
    class Program
    {
        public static IUIService _uiService = new UIService();

        public static IUserService<StandardUser> _standardUserService = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserService = new UserService<PremiumUser>();
        public static IUserService<TrainerUser> _trainerUserService = new UserService<TrainerUser>();

        public static ITrainingService<VideoTraining> _videoTrainingService = new TraingingService<VideoTraining>();
        public static ITrainingService<LiveTraining> _liveTrainingService = new TraingingService<LiveTraining>();

        public static User _currentUser;

        public static void Seed()
        {
            _standardUserService.Register(new StandardUser { FirstName = "Martin", LastName = "Panovski", UserName = "martinpano", Password = "martin123" });
            _premiumUserService.Register(new PremiumUser { FirstName = "Petre", LastName = "Arsovski", UserName = "petrea", Password = "petre123" });

            TrainerUser trainer = new TrainerUser { FirstName = "Bob", LastName = "Bobsky", UserName = "bobtrainer", Password = "bob123", YearsOfExperience = 6 };
            _trainerUserService.Register(trainer);

            _videoTrainingService.AddTraining(new VideoTraining { Title = "30 min workout", Description = "Cool workout for beginners!", Difficulty = Difficulty.Easy, Link = "", Raiting = 4, Duration = 35 });
            _videoTrainingService.AddTraining(new VideoTraining { Title = "ABS workout", Description = "ABS workout for professionals!", Difficulty = Difficulty.Hard, Link = "", Raiting = 5, Duration = 45 });

            _liveTrainingService.AddTraining(new LiveTraining { Title = "Legs workout", Description = "Medium legs workout", Difficulty = Difficulty.Medium, Link = "", NextSession = new DateTime(2021, 06, 10), Duration = 60, Trainer = trainer });
            _liveTrainingService.AddTraining(new LiveTraining { Title = "Cardio workout for professionals", Description = "Cardio workout", Difficulty = Difficulty.Hard, Link = "", NextSession = new DateTime(2021, 06, 11), Duration = 60, Trainer = trainer });

        }

        static void Main(string[] args)
        {
            Seed();

            while (true)
            {
                if(_currentUser == null)
                {
                    int loginChoice = _uiService.LoginMenu();
                    if(loginChoice == 1)
                    {
                        //TODO: Add login logic here
                        int roleChoice = _uiService.RoleMenu();
                        UserRole role = (UserRole)roleChoice;
                        Console.Clear();
                        Console.WriteLine("Enter username:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        string password = Console.ReadLine();
                        switch (role)
                        {
                            case UserRole.Standard:
                                _currentUser = _standardUserService.LogIn(userName, password);
                                break;
                            case UserRole.Premium:
                                _currentUser = _premiumUserService.LogIn(userName, password);
                                break;
                            case UserRole.Trainer:
                                _currentUser = _trainerUserService.LogIn(userName, password);
                                break;
                            default:
                                break;
                        }
                        if (_currentUser == null) continue;
                    }
                    else
                    {
                        //TODO: Add register logic here
                        StandardUser newUser = new StandardUser();
                        Console.WriteLine("Enter first name:");
                        newUser.FirstName = Console.ReadLine();

                        Console.WriteLine("Enter last name:");
                        newUser.LastName = Console.ReadLine();

                        Console.WriteLine("Enter username:");
                        newUser.UserName = Console.ReadLine();

                        Console.WriteLine("Enter password:");
                        newUser.Password = Console.ReadLine();

                        StandardUser user = _standardUserService.Register(newUser);
                        if (user == null) continue;
                        _currentUser = user;
                    }
                    _uiService.Welcome(_currentUser);
                }

                //TODO: Add the logic here if _currentUser is not null
                int mainMenuChoice = _uiService.MainMenu(_currentUser.Role);
                string mainMenuItem = _uiService.MainMenuItems[mainMenuChoice - 1];
                switch (mainMenuItem)
                {
                    case "Train":
                        int trainChoice = 1;
                        if (_currentUser.Role == UserRole.Premium)
                            trainChoice = _uiService.TrainMenu();
                        if(trainChoice == 1)
                        {
                            int trainingItem = _uiService.TrainMenuItems(_videoTrainingService.GetTrainings());
                            VideoTraining training = _videoTrainingService.GetTrainings()[trainingItem - 1];
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"Link: { training.Link }");
                            Console.WriteLine($"Raiting: { training.CheckRaiting() }");
                            Console.ReadLine();
                        }
                        if(trainChoice == 2)
                        {
                            int trainingItem = _uiService.TrainMenuItems(_liveTrainingService.GetTrainings());
                            LiveTraining training = _liveTrainingService.GetTrainings()[trainingItem - 1];
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"Training starts at: { training.NextSession }");
                            Console.WriteLine($"Raiting: { training.CheckRaiting() }");
                            Console.ReadLine();
                        }
                        break;

                    case "Upgrade to premium":
                        _uiService.UpgradeToPremium();
                        break;

                    case "Reschedule training":
                        List<LiveTraining> trainings = _liveTrainingService.GetTrainings().Where(x => x.Trainer.Id == _currentUser.Id).ToList();
                        if(trainings.Count == 0)
                        {
                            Console.WriteLine("No trainings in the training list");
                            Console.ReadLine();
                        }
                        else
                        {
                            int trainingChoice = _uiService.ChooseEntititesMenu(trainings);
                            Console.WriteLine("How many days do you want to reschedule the training:");
                            int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 30);
                            _trainerUserService.GetUserById(_currentUser.Id).ChangeSchedule(trainings[trainingChoice - 1], days);
                            Console.WriteLine("Schedule changed!");
                            Console.ReadLine();
                        }
                        break;


                    case "Account":
                        int accountChoice = _uiService.AccountMenu(_currentUser.Role);
                        Console.Clear();
                        if (accountChoice == 1)
                        {
                            // Change Info
                            Console.WriteLine("Enter new First Name:");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter new Last Name:");
                            string lastName = Console.ReadLine();
                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
                                    _standardUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Premium:
                                    _premiumUserService.ChangePassword(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Trainer:
                                    _trainerUserService.ChangePassword(_currentUser.Id, firstName, lastName);
                                    break;
                            }
                        }
                        else if (accountChoice == 2)
                        {
                            // Check Subscription
                            Console.WriteLine($"Your subscription is: {_currentUser.Role}");
                            Console.ReadLine();
                        }
                        else if (accountChoice == 3)
                        {
                            // Change info
                            Console.WriteLine("Enter old password:");
                            string oldPass = Console.ReadLine();
                            Console.WriteLine("Enter new password:");
                            string newPass = Console.ReadLine();
                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
                                    _standardUserService.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                                case UserRole.Premium:
                                    _premiumUserService.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                                case UserRole.Trainer:
                                    _trainerUserService.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                            }
                        }
                        break;

                    case "Log out":
                        _currentUser = null;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
