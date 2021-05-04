using CinemaApp.Models.Enums;
using System.Collections.Generic;

namespace CinemaApp.Models.Classes
{
    public class Cinema
    {
        public Cinema(CinemaType type)
        {
            ID = _id++;
            CinemaType = type;
            MovieHalls = new List<MovieHall>();
        }
        private static int _id = 1;
        public int ID { get; set; }
        public string CienemaName { get; set; }
        public int MaxCapacity { get; set; }
        public CinemaType CinemaType { get; set; }
        public List<MovieHall> MovieHalls { get; set; }
    }
}
