using System;

namespace SEDC.CSharpAdv.VideoRental.Data.Models
{
    public class RentalInfo
    {
        public Movie Movie { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

        public RentalInfo()
        {
        }

        public RentalInfo(Movie movie)
        {
            Movie = movie;
            DateRented = DateTime.Now;
            DateReturned = null;
        }
    }
}
