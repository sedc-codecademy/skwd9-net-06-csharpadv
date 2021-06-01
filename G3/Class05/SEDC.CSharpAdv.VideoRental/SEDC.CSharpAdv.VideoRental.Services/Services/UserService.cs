using SEDC.CSharpAdv.VideoRental.Data.Database;
using SEDC.CSharpAdv.VideoRental.Data.Enumerations;
using SEDC.CSharpAdv.VideoRental.Data.Models;
using SEDC.CSharpAdv.VideoRental.Services.Helpers;
using SEDC.CSharpAdv.VideoRental.Services.Interfaces;
using SEDC.CSharpAdv.VideoRental.Services.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SEDC.CSharpAdv.VideoRental.Services.Services
{
    public class UserService : IUserService
    {
        private UserRepository _userRepository;
        private MovieRepository _movieRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
            _movieRepository = new MovieRepository();
        }

        public User Login()
        {
            while (true)
            {
                Console.Write("Enter card number: ");
                int idCard = InputParser.ToInteger(100, 999);

                User user = _userRepository.GetUserByIdCard(idCard);
                // loading indicators

                if(user != null)
                {
                    RenewSubscription(user);
                    Console.WriteLine($"Welcome {user.FullName}");
                    return user;
                }
                Console.WriteLine("User card id does not exists");
                Console.WriteLine("Try again y/n");
                if (!InputParser.ToConfirm())
                {
                    Console.WriteLine("Thank you for useing rent a video app.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
        }

        public User SignUp()
        {
            while (true)
            {
                Console.Write("Enter full name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter date of birth");
                DateTime dob = InputParser.ToDateTime();
                int cardNumber = GenerateNewCardNumber();

                Console.WriteLine("Creating user please wait");
                // loading indicator

                User user = new User
                {
                    CardNumber = cardNumber,
                    FullName = name,
                    DateOfBirth = dob
                };
                _userRepository.Insert(user);
                return user;
            }
        }

        public void ViewRentedMovies(User user)
        {
            bool isActive = false;
            while(!isActive)
            {
                Screen.ClearScreen();
                user.ViewRentedMovies();
                Screen.RentedMenu();
                int selection = InputParser.ToInteger(0, 2);
                switch (selection)
                {
                    case 1:
                        user.ViewRentedMovies();
                        break;
                    case 2:
                        ReturnMovie(user);
                        break;
                    case 0:
                        isActive = !isActive;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ReturnMovie(User user)
        {
            if(user.RentedMovies.Count == 0)
            {
                Console.WriteLine("You dont have any movies rented");
                return;
            }

            Console.WriteLine("Enter movie id in order to return a movie");
            var movieId = InputParser.ToInteger(1, int.MaxValue);

            var rental = user.RentedMovies.FirstOrDefault(x => x.Movie.Id == movieId);
            if(rental != null)
            {
                rental.DateReturned = DateTime.Now;
                var movie = _movieRepository.GetById(movieId);
                if(movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                movie.Quantity += 1;

                user.RentalHistory.Add(rental);
                user.RentedMovies.Remove(rental);

                _userRepository.Update(user);
                _movieRepository.Update(movie);
            }
            else
            {
                Console.WriteLine("You do not have that movie rented. Please enter valid movie id");
                return;
            }
        }

        private int GenerateNewCardNumber()
        {
            const int max = 999;
            const int min = 100;
            Random rnd = new Random();
            List<int> takenCardNumbers = _userRepository.GetAllCardNumbers();

            int cardNumber;
            do
            {
                cardNumber = rnd.Next(min, max);
            } 
            while (takenCardNumbers.Contains(cardNumber));
            return cardNumber;
        }

        private void RenewSubscription(User user)
        {
            if(user.SubscriptionExpireTime < DateTime.Now)
            {
                user.IsSubscriptionExpired = true;
            }

            if (user.IsSubscriptionExpired)
            {
                Console.WriteLine("Your subscription is expired. Do you want to renew y/n");
                bool renew = InputParser.ToConfirm();
                // loading indicator

                if (!renew)
                {
                    Console.WriteLine("Thank you for useing rent a video app.");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                else
                {
                    user.IsSubscriptionExpired = false;
                    user.SubscriptionExpireTime = DateTime.Now.AddYears(1);
                    Console.WriteLine($"Your subscription is extended untill {user.SubscriptionExpireTime.ToShortDateString()}");
                }
            }
        }
    }
}
