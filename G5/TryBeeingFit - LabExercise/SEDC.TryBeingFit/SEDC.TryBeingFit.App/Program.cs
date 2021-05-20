using SEDC.TryBeingFit.Domain.Core.Entities.Training;
using SEDC.TryBeingFit.Domain.Core.Entities.User;
using SEDC.TryBeingFit.Domain.Core.Enum;
using SEDC.TryBeingFit.Services.Services.Classes;
using SEDC.TryBeingFit.Services.Services.Interfaces;
using System;

namespace SEDC.TryBeingFit.App
{
    class Program
    {
        public static IUserService<StandardUser> _standardUserService = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserService = new UserService<PremiumUser>();
        public static IUserService<TrainerUser> _trainerUserService = new UserService<TrainerUser>();

        public static ITrainingService<VideoTraining> _videoTrainingService = new TrainingService<VideoTraining>();
        public static ITrainingService<LiveTraining> _liveTrainingService = new TrainingService<LiveTraining>();

        public static User _currentUser;

        public static void Seed() 
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

        static void Main(string[] args)
        {
            Seed();

            while (true) { }
        }


    }
}
