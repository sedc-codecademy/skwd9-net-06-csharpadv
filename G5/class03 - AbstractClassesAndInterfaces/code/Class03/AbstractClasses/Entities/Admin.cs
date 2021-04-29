using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class Admin : User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public override void SayGoodbye(string name)
        {
            Console.WriteLine($"Bye, {name}");
        }
    }
}
