using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public abstract class User
    {
        //Abstract classes can have properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract classes can have a constructor
        public User()
        {
        }

        //Abstract classes can have Methods with implementation
        public void SayHello(string name) 
        {
            Console.WriteLine($"Hello, {name}");
        }

        //Abstract classes can have Methods without implementation
        //This is a signature of a method
        public abstract void SayGoodbye(string name);
    }
}
