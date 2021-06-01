using SEDC.CSharpAdv.VideoRental.Data.BaseModels;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.VideoRental.Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        // card number is used as a username
        public int CardNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public DateTime SubscriptionExpireTime { get; set; }

        public List<RentalInfo> RentedMovies { get; set; }
        public List<RentalInfo> RentalHistory { get; set; }

        // custom geter
        public int Age 
        { 
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            } 
        }

        public User()
        {
            RentalHistory = new List<RentalInfo>();
            RentedMovies = new List<RentalInfo>();
        }

        public void ViewRentedMovies()
        {
            if (RentedMovies.Count == 0)
            {
                Console.WriteLine("There is no rented movies.");
            }
            else
            {
                foreach (var rental in RentedMovies)
                {
                    Console.WriteLine($"{rental.Movie.Title} rented at {rental.DateRented}");
                }
            }
        }
    }
}
