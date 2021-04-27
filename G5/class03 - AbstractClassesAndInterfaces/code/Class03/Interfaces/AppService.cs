using Interfaces.Services.Classes;
using Interfaces.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class AppService
    {
        public IGreetingsService _gs { get; set; }
        public AppService()
        {
            _gs = new GreetingsService2();
        }
        public void RunApp() 
        {
            _gs.SayHello("Viktor");

            var name = _gs.ReturnName("Viktor");
            var nameToUpper = name.ToUpper();

            Console.WriteLine(nameToUpper);
        }
    }
}
