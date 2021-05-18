using SEDC.CSharpAdv.VideoRental.Data.Models;

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
    }
}
