using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Implementations;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace SEDC.TryBeingFit.App
{
    class Program
    {
        //Added reference to SEDC.TryBeingFit.Services
        //each service has its own database
        public static ITrainingService<VideoTraining> _videoTrainingService = new TrainingService<VideoTraining>();
        public static ITrainingService<LiveTraining> _liveTrainingService = new TrainingService<LiveTraining>();
        public static IUserService<Trainer> _trainerService = new UserService<Trainer>();
        public static IUserService<StandardUser> _standardUserService = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserService = new UserService<PremiumUser>();
        public static IUIService _uiService = new UIService();
        public static User _currentUser;
        static void Main(string[] args)
        {
            Seed();

            //List<VideoTraining> videoTrainingsDb = _videoTrainingService.GetAllTrainings();
            //Trainer trainerBill = _trainerService.LogIn("bill", "bill");
            //Trainer trainerPaul = _trainerService.LogIn("paul.paulsky", "paul.paulsky3");
            //_trainerService.ChangePassword(trainerPaul.Id, "paul.paulsky3", "paul.paulsky3333");
            //Trainer paulDb = _trainerService.ChangeInfo(trainerPaul.Id, "PaulUpdated", "Paulsky2");



            //int hashedString = "test123".GetHashCode();
            //int hashedString2 = "test123".GetHashCode();


            int option = _uiService.LogInMenu();
            Console.Clear();
            if (option == 1)
            {
                int roleChoice = _uiService.RoleMenu();
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                if (string.IsNullOrEmpty(username))
                {
                    throw new Exception("You must enter username");
                }
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("You must enter password");
                }
                UserRole role = (UserRole)roleChoice;
                switch (role)
                {
                    case UserRole.Standard:
                        _currentUser = _standardUserService.LogIn(username, password);
                        break;
                    case UserRole.Premium:
                        _currentUser = _premiumUserService.LogIn(username, password);
                        break;
                    case UserRole.Trainer:
                        _currentUser = _trainerService.LogIn(username, password);
                        break;
                }
            }
            else
            {
                StandardUser standardUser = new StandardUser();

                Console.WriteLine("Enter first name");
                string firstName = Console.ReadLine();
                if (string.IsNullOrEmpty(firstName))
                {
                    throw new Exception("You must enter first name");
                }
                Console.WriteLine("Enter last name");
                string lastName = Console.ReadLine();
                if (string.IsNullOrEmpty(lastName))
                {
                    throw new Exception("You must enter last name");
                }

                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                if (string.IsNullOrEmpty(username))
                {
                    throw new Exception("You must enter username");
                }
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("You must enter password");
                }
                standardUser.FirstName = firstName;
                standardUser.LastName = lastName;
                standardUser.Username = username;
                standardUser.Password = password;

                _currentUser = _standardUserService.Register(standardUser);
            }



            Console.ReadLine();

        }

        public static void Seed()
        {
            _standardUserService.Register(new StandardUser()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Username = "bob.bobsky",
                Password = "bob.bobsky1"
            });
            _premiumUserService.Register(new PremiumUser()
            {
                FirstName = "Anne",
                LastName = "Bobsky",
                Username = "anne.bobsky",
                Password = "anne.bobsky2"
            });
            Trainer paul = new Trainer()
            {
                FirstName = "Paul",
                LastName = "Paulsky",
                Username = "paul.paulsky",
                Password = "paul.paulsky3",
                YearsOfExperience = 3
            };
            Trainer registeredTrainer = _trainerService.Register(paul);
            _videoTrainingService.AddTraining(new VideoTraining()
            {
                Title = "Abs workout",
                Description = "Abs workout made easy",
                Difficulty = TrainingDifficulty.Easy,
                Link = "someLink",
                Rating = 3,
                Time = 15.55
            });
            _videoTrainingService.AddTraining(new VideoTraining()
            {
                Title = "Cardio",
                Description = "Dance cardio",
                Difficulty = TrainingDifficulty.Medium,
                Link = "someLink",
                Rating = 5,
                Time = 25
            });

            _liveTrainingService.AddTraining(new LiveTraining()
            {

                Title = "Cardio",
                Description = "Dance cardio",
                Difficulty = TrainingDifficulty.Medium,
                NextSession = DateTime.Now.AddDays(1),
                Trainer = registeredTrainer,
                Rating = 5,
                Time = 25,
            });
        }
    }
}
