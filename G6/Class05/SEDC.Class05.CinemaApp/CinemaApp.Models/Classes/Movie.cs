using CinemaApp.Models.Enums;

namespace CinemaApp.Models.Classes
{
    public class Movie
    {
        public Movie(string movieTitle, int duration, string director, MovieGenre genre)
        {
            ID = _id++;
            this.MovieTitle = movieTitle;
            this.MovieDuration = duration;
            this.MovieDirector = director;
            this.Genre = genre;
        }
        private static int _id = 1;
        public int ID { get; set; }
        public string MovieTitle { get; set; }
        public int MovieDuration { get; set; }
        public string MovieDirector { get; set; }
        public MovieGenre Genre { get; set; }

        public static void PrintMovieInfo(Movie movie)
        {
            System.Console.WriteLine($"The movie {movie.MovieTitle} is playing and the duration is {movie.MovieDuration} {movie.Genre}");
        }
    }
}
