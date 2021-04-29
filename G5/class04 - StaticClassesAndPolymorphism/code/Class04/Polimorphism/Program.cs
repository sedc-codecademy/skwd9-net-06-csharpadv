using Polimorphism.Entities;
using System;

namespace Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Runtime polymorphism
            var majlo = new Dog() 
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
