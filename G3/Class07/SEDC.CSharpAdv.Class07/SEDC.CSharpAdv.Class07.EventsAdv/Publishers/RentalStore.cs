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
        //old way
        //public delegate void RentalStoreEventHandler(object source, EventArgs args);
        //public event RentalStoreEventHandler NotifyUsers;

        public event EventHandler NotifyUsers;

        public void AddNewMovie(string movieTitle)
        {
            Console.WriteLine("Adding movie ...");
            Thread.Sleep(2000);
            Console.WriteLine($"Added movie with title {movieTitle}.");

            OnNewMovie();
        }

        protected virtual void OnNewMovie()
        {
            if(NotifyUsers != null)
            {
                NotifyUsers(this, EventArgs.Empty);
            }
        }
    }
}
