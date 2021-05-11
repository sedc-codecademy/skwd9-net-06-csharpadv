using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsExercise.Entities
{
    public delegate void AnnounceMarkDelegate(string name, int mark);
    public class Trainer
    {
        public event AnnounceMarkDelegate EventHandler;

        public void Announce(string name, int mark)
        {
            Console.WriteLine($"Student: {name} got mark {mark}");

            EventHandler?.Invoke(name, mark);
            Thread.Sleep(5000);
        }
    }
}
