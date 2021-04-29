using Interfaces.Services.Classes;
using Interfaces.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class AppService
    {
        public IGreetingsService _greetingsService { get; set; }
        public AppService()
        {
            _greetingsService = new GreetingsService();
            //_greetingsService = new GreetingsService2();
        }

        public void RunApp() 
        {
            _greetingsService.SayHello("Viktor");

            var name = _greetingsService.ReturnName("Viktor");
            var nameToUpper = name.ToUpper();

            Console.WriteLine(nameToUpper);
        }
    }
}
