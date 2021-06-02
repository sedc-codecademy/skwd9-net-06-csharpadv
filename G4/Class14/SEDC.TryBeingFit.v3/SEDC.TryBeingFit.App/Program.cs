using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Services.Implementations;
using SEDC.TryBeingFit.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.TryBeingFit.App
{
    class Program
    {
        // creating instances of the services
        public static IUserService<StandardUser> _standardUserService = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserService = new UserService<PremiumUser>();
        public static IUserService<TrainerUser> _trainerUserService = new UserService<TrainerUser>();
        public static ITrainingService<LiveTraining> _liveTrainingService = new TrainingService<LiveTraining>();
        public static ITrainingService<VideoTraining> _videoTrainingService = new TrainingService<VideoTraining>();
        public static IUIService _uiService = new UIService();
        public static User _currentUser;

        public static void Seed()
        {
            if (_standardUserService.IsDbEmpty() && _premiumUserService.IsDbEmpty() && _trainerUserService.IsDbEmpty())
            {
                _standardUserService.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
                _premiumUserService.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jilllw", Password = "jillsuper26" });
                TrainerUser John = new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55", YearsExperience = 7 };
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
            try
            {
                // TO DO:
                // 1. Define entities in Domain -- done
                // 2. Basic UI in App -- done
                // 3. Core methods in Services -- done
                // 4. Write helper methods in Services -- done
                Seed();

                while (true)
                {
                    // if he do not have logged user
                    if (_currentUser == null)
                    {
                        int loginChoice = _uiService.LoginMenu();

                        if(loginChoice == 1)
                        {
                            // choose to login
                            int roleChoice = _uiService.RoleMenu();
                            UserRole role = (UserRole)roleChoice;
                            Console.Clear();
                            Console.WriteLine("Enter username:");
                            string username = Console.ReadLine();
                            Console.WriteLine("Enter password:");
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
                                default:
                                    break;
                            }
                            if (_currentUser == null) continue;
                        }
                        else
                        {
                            // choose to register
                            StandardUser newUser = new StandardUser();
                            Console.WriteLine("Enter first name:");
                            newUser.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter last name:");
                            newUser.LastName = Console.ReadLine();
                            Console.WriteLine("Enter username:");
                            newUser.Username = Console.ReadLine();
                            Console.WriteLine("Enter password:");
                            newUser.Password = Console.ReadLine();
                            User user = _standardUserService.Register(newUser);

                            if (user == null) continue;
                            _currentUser = user;
                        }
                        _uiService.Welcome(_currentUser);
                    }

                    // if we already have a logged user
                    int mainMenuChoice = _uiService.MainMenu(_currentUser.Role);
                    string mainMenuItem = _uiService.MainMenuItems[mainMenuChoice - 1];
                    switch (mainMenuItem)
                    {
                        case "Train":
                            int trainChoice = 1;
                            if (_currentUser.Role == UserRole.Premium) trainChoice = _uiService.TrainMenu();
                            if (trainChoice == 1)
                            {
                                int trainingItem = _uiService.TrainMenuItems(_videoTrainingService.GetTrainings());
                                VideoTraining training = _videoTrainingService.GetTrainings()[trainingItem - 1];
                                Console.WriteLine(training.Title);
                                Console.WriteLine($"Link: {training.Link}");
                                Console.WriteLine($"Raiting: {training.CheckRating()}");
                                Console.WriteLine($"Time: {training.Time} minutes");
                                Console.ReadLine();
                            }
                            if (trainChoice == 2)
                            {
                                int trainingItem = _uiService.TrainMenuItems(_liveTrainingService.GetTrainings());
                                LiveTraining training = _liveTrainingService.GetTrainings()[trainingItem - 1];
                                Console.WriteLine(training.Title);
                                Console.WriteLine($"THE TRAINING STARTS AT: {training.NextSession}");
                                Console.WriteLine($"Raiting: {training.CheckRating()}");
                                Console.WriteLine($"Time: {training.Time} minutes");
                                Console.ReadLine();
                            }
                            break;
                        case "Upgrade to Premium":
                            _uiService.UpgradeToPremium();
                            break;
                        case "Reschedule training":
                            List<LiveTraining> trainings = _liveTrainingService.GetTrainings().Where(x => x.Trainer.Id == _currentUser.Id).ToList();
                            if (trainings.Count == 0)
                            {
                                Console.WriteLine("No Trainings!");
                                Console.ReadLine();
                            }
                            else
                            {
                                int trainingChoice = _uiService.ChooseEntitiesMenu(trainings);
                                Console.WriteLine("How many days do you want to reschedule the training:");
                                int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 100);
                                _trainerUserService.GetById(_currentUser.Id).ChangeSchedule(trainings[trainingChoice - 1], days);
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
                                // Change password
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
                        case "Log Out":
                            _currentUser = null;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            

            

            Console.ReadLine();
        }
    }
}
