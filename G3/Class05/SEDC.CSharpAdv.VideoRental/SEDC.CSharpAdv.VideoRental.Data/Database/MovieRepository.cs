using SEDC.CSharpAdv.VideoRental.Data.Enumerations;
using SEDC.CSharpAdv.VideoRental.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpAdv.VideoRental.Data.Database
{
    public class MovieRepository : GenericRepository<Movie>
    {
        public MovieRepository()
            : base(InMemoryDatabase.Movies, InMemoryDatabase.movieId)
        {
        }

        // reworked into one generic
        //public List<Movie> GetByGenre(Genre genre)
        //{
        //    return Db.Where(x => x.Genre == genre).ToList();
        //}

        //public List<Movie> GetByYear(int year)
        //{
        //    return Db.Where(x => x.ReleaseDate.Year == year).ToList();
        //}

        //public List<Movie> GetAvailableMovies()
        //{
        //    return Db.Where(x => x.IsAvailable).ToList();
        //}

        public List<Movie> OrderByGenre(bool isAscending)
        {
            if (isAscending)
            {
                return Db.OrderBy(x => x.Genre).ToList();
            }
            return Db.OrderByDescending(x => x.Genre).ToList();
        } 

        public List<Movie> OrderByReleaseDate(bool isAscending)
        {
            if (isAscending)
            {
                return Db.OrderBy(x => x.ReleaseDate).ToList();
            }
            return Db.OrderByDescending(x => x.ReleaseDate).ToList();
        }

        public List<Movie> OrderByAvailability(bool isAscending)
        {
            if (isAscending)
            {
                return Db.OrderBy(x => x.IsAvailable).ToList();
            }
            return Db.OrderByDescending(x => x.IsAvailable).ToList();
        }
    }
}
