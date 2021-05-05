using Polimorphism.Entities;
using Polimorphism.Services;
using System;

namespace Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compile time polymorphism
            GreetingsService _greetingService = new GreetingsService();
            _greetingService.SayHello("Viktor");
            _greetingService.SayHello("Viktor", "Jakovlev");
            _greetingService.SayHello("Viktor", "Milan", "Jakovlev");
            _greetingService.SayHello("Viktor", "Jakovlev", 31);

            var options = new GreetingsOptions()
            {
                Name = "Viktor",
                MiddleName = "Milan",
                LastName = "Jakovlev"
            };

            _greetingService.SayHello(options);

            //Runtime polymorphism
            Dog majlo = new Dog() 
            {
                Name = "Majlo",
                IsGoodBoy = true
            };

            majlo.Eat(); 

            var george = new Cat()
            {
                Name = "George",
                IsLazy = false
            };

            george.Eat();

            Console.ReadLine();
        }
    }
}
