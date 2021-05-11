using SEDC.CSharpAdv.Class07.EventsAdv.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.CSharpAdv.Class07.EventsAdv.Publishers
{
    public class RentalStore
    {
        // 1 - define delegate
        // 2 - define event
        // 3 - raise event
        //old way with out custom params
        //public delegate void RentalStoreEventHandler(object source, EventArgs args);
        //public event RentalStoreEventHandler NotifyUsers;

        //old way with custom params
        //public delegate void RentalStoreEventHandler(object source, MovieEventArgs args);
        //public event RentalStoreEventHandler NotifyUsers;

        //public event EventHandler NotifyUsers; // uncoment this with OnNewMovie Code to work;
        public event EventHandler<MovieEventArgs> NotifyUsers;

        public event EventHandler<VideoEventArgs> NotifyUsersVideoEvent;

        public void AddNewMovie(string movieTitle)
        {
            Console.WriteLine("Adding movie ...");
            Thread.Sleep(2000);
            Console.WriteLine($"Added movie with title {movieTitle}.");

            var movie = new Movie
            {
                Title = movieTitle,
                Duration = 123,
                ReleaseDate = DateTime.Now
            };

            //OnNewMovie();
            OnNewMovie(movieTitle);
            OnNewMovie(movie);
        }

        protected virtual void OnNewMovie()
        {
            //if(NotifyUsers != null)
            //{
            //    NotifyUsers(this, EventArgs.Empty);
            //}
        }

        protected virtual void OnNewMovie(string movie)
        {
            if(NotifyUsers != null)
            {
                NotifyUsers(this, new MovieEventArgs { Title = movie });
            }
        }

        protected virtual void OnNewMovie(Movie movie)
        {
            if(NotifyUsersVideoEvent != null)
            {
                var args = new VideoEventArgs { Movie = movie };
                NotifyUsersVideoEvent(this, args);
            }
        }
    }
}
