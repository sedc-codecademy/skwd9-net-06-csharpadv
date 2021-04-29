using Interfaces.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services.Classes
{
    public class GreetingsService2 : IGreetingsService
    {
        public string ReturnName(string name)
        {
            return name + " Version 2";
        }

        public void SayGoodBye(string name)
        {
            Console.WriteLine($"Bye, {name}");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
