using Interfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Classes
{
    public class User : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void SayGoodBye(string name)
        {
            Console.WriteLine($"Bye, {name}");
        }

    }
}
