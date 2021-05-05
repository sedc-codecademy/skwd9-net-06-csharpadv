using CinemaApp.Models.Classes;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp.Models.Db
{
    public static class MockUpDatabase
    {
        public static List<User> Users { get; set; }
        public static List<Cinema> Cinemas { get; set; }
        public static List<MovieHall> MovieHalls { get; set; }
        public static List<Movie> Movies { get; set; }
        static MockUpDatabase()
        {
            Users = new List<User>
            {
                new User("Damjan","Stojanovski","damjan123","pass123"),
                new User("Petre","Arsovski","petre123","pass123")
            };

            Cinemas = new List<Cinema>
            {
                new Cinema(Enums.CinemaType.Close_Cinema)
                {
                    CienemaName = "Cineplexx",
                    MaxCapacity = 300,
                    MovieHalls = MovieHalls.Where(x => x.MaxCapacity == 120).ToList()
                },
                new Cinema(Enums.CinemaType.Close_Cinema)
                {
                    CienemaName = "Milenium",
                    MovieHalls = MovieHalls.Where(x => x.ID == 1 || x.ID == 3).ToList()
                }
            };

            MovieHalls = new List<MovieHall>
            {
                new MovieHall()
                {
                    MaxCapacity = 50,
                    Movies = Movies.Where(m => m.ID == 1).ToList()
                },
                new MovieHall()
                {
                    MaxCapacity = 120,
                    Movies = Movies.Where(m => m.ID == 2 || m.ID == 3).ToList()
                },
                new MovieHall()
                {
                    MaxCapacity = 70
                }
            };

            Movies = new List<Movie>
            {
                new Movie("Scary movie", 120,"Woody Alen",Enums.MovieGenre.Horror),
                new Movie("Die hard", 150,"Bruice Willis",Enums.MovieGenre.Action),
                new Movie("Die hard 2", 180,"Bruice Willis",Enums.MovieGenre.Action)
            };
        }
        //CRUD opearations
        //Create, Read, Update, Delete
        public static List<User> GetAllUsers()
        {
            return Users;
        }

        public static User GetUserById(int id)
        {
            return Users.SingleOrDefault(x => x.GetUserId() == id);
        }

        public static Cinema GetCinemaByCinemaId(int id)
        {
            return Cinemas.SingleOrDefault(x => x.ID == id);
        }

        public static List<MovieHall> GetMovieHallsByCinemaId(int cinemaId)
        {
            var cinema = Cinemas.SingleOrDefault(x => x.ID == cinemaId);
            if(cinema == null)
            {
                return new List<MovieHall>();
            }
            return cinema.MovieHalls;
        }

        public static List<Movie> GetMoviesByMovieHallId(int movieHallId)
        {
            var movieHall = MovieHalls.SingleOrDefault(mh => mh.ID == movieHallId);
            if(movieHall == null)
            {
                return new List<Movie>();
            }
            return movieHall.Movies;
        }
        //Inserting a record to the mockup database implementation
        public static int AddUserToUsersTable(User user)
        {
            if(Users.Any(x => x.GetUserId() == user.GetUserId() || x.Username == user.Username))
            {
                throw new System.Exception("The user with that id already exists. Can not add a user with that id");
            }

            Users.Add(user);
            return 1;
        }
        //This function always will return 1 eather will update the user or will create a new one
        public static int UpdateUser(User user)
        {
            var usertoUpdate = Users.SingleOrDefault(x => x.GetUserId() == user.GetUserId());
            if(usertoUpdate == null)
            {
                //Here we call a function from the same static class into an other function
                MockUpDatabase.AddUserToUsersTable(user);
            }
            string.Compare("sdf", "dfs");
            usertoUpdate.FirstName = user.FirstName;
            usertoUpdate.LastName = user.LastName;
            usertoUpdate.Address = user.Address;
            usertoUpdate.Password = user.Password;
            usertoUpdate.Billance = user.Billance;
            return 1;
        }
    }
}
