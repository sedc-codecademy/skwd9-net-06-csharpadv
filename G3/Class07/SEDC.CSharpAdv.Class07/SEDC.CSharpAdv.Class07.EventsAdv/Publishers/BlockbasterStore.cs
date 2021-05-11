using SEDC.CSharpAdv.Class07.EventsAdv.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class07.EventsAdv.Publishers
{
    public class BlockbasterStore
    {
        public event EventHandler<VideoEventArgs> Notifications;

        public void NewMovieRelease(string movie)
        {
            Console.WriteLine($"{movie} is now available on Dvd");

            OnNewMovieRelease(movie);
        }

        protected virtual void OnNewMovieRelease(string movieTitle)
        {
            // if notification is null Invoke will not trigger
            //Notifications?.Invoke(this, new MovieEventArgs() { Title = movie });
            if (Notifications != null)
            {
                var movie = new Movie
                {
                    Title = movieTitle,
                    Duration = 1234,
                    ReleaseDate = DateTime.Now.AddDays(-14)
                };
                Notifications(this, new VideoEventArgs() { Movie = movie });
            }
        }
    }
}
