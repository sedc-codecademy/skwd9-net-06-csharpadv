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

namespace SEDC.CSharpAdv.VideoRental.Services.Services
{
    public class MovieService : IMovieService
    {
        private MovieRepository _movieRepository;

        public MovieService()
        {
            _movieRepository = new MovieRepository();
        }

        public void ViewMovieList(User user)
        {
            List<Movie> movies = new List<Movie>();
            bool isFinished = false;
            while (!isFinished)
            {
                Screen.ClearScreen();
                if (movies.Count != 0)
                {
                    movies.PrintMovies();
                }
                Screen.OrderingMenu();
                var selection = InputParser.ToInteger(0, 9);
                switch(selection)
                {
                    case 1:
                        movies = _movieRepository.GetAll();
                        break;
                    case 2:
                        movies = _movieRepository.OrderByGenre(true);
                        break;
                    case 3:
                        Genre genre = InputParser.ToGenre();
                        movies = _movieRepository.Filter(x => x.Genre == genre);
                        break;
                    case 4:
                        movies = _movieRepository.OrderByReleaseDate(true);
                        break;
                    case 5:
                        int year = InputParser.ToInteger(
                                _movieRepository.GetAll().Min(_movie => _movie.ReleaseDate.Year),
                                DateTime.Now.Year - 1
                            );
                        movies = _movieRepository.Filter(x => x.ReleaseDate.Year == year);
                        break;
                    case 6:
                        movies = _movieRepository.OrderByAvailability(true);
                        break;
                    case 7:
                        movies = _movieRepository.Filter(x => x.IsAvailable);
                        break;
                    case 8:
                        string titlePart = Console.ReadLine();
                        string trimedTitlePart = titlePart.Trim().ToLower();
                        movies = _movieRepository.Filter(x => x.Title.ToLower().Contains(trimedTitlePart));
                        break;
                    case 9:
                        //TODO:
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                }
            }
        }
    }
}
