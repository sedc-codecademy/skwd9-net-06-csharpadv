using System.Collections.Generic;

namespace CinemaApp.Models.Classes
{
    public class MovieHall
    {
        public MovieHall()
        {
            ID = _id++;
            Movies = new List<Movie>();
        }
        private static int _id = 1;
        public int ID { get; set; }
        public int MaxCapacity { get; set; }
        public List<Movie> Movies { get; set; }

        public static void GetMoviesCatalog(MovieHall movieHall)
        {
            movieHall.Movies.ForEach(movie => System.Console.WriteLine(movie.MovieTitle));
        }
    }
}
