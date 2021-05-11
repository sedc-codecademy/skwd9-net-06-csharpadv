using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class07.Events
{
    public class VideoStore
    {
        // 1 - define delegate
        // 2 - define event
        // 3 - raise event

        public delegate void AddNewMovieEventHandler(string movie);
        public event AddNewMovieEventHandler NotifyUsers;

        public void AddNewMovie(string movie)
        {
            Console.WriteLine("Adding movie " + movie);

            NewMovieAdded(movie);
        }

        // this is by convention
        protected virtual void OnNewMovie(string movie)
        {
            if (NotifyUsers != null)
            {
                NotifyUsers(movie);
            }
        }

        // this is our way
        public void NewMovieAdded(string movie)
        {
            if(NotifyUsers != null)
            {
                NotifyUsers(movie);
            }
        }
    }
}
