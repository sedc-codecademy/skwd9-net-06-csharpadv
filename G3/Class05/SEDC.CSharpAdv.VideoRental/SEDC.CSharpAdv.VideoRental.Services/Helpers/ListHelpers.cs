using SEDC.CSharpAdv.VideoRental.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Services.Helpers
{
    public static class ListHelpers
    {
        public static void PrintMovies(this List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                //string availablity = movie.IsAvailable ? "Yes" : "No";
                //string movieInfo = string.Format(
                //    "Rent id: {0} Title: {1}, Release date: {2}, Genre: {3}, Available: {4}, Quantity: {5}",
                //    movie.Id, movie.Title, movie.ReleaseDate.ToString("MMMM dd yyyy"), movie.Genre, availablity, movie.Quantity);
                //Console.WriteLine(movieInfo);
                Console.WriteLine(Movie.GetMovieInfo(movie));
            }
        }
    }
}
