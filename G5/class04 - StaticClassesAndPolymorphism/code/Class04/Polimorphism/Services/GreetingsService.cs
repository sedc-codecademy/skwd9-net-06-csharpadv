using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism.Services
{
    public class GreetingsService
    {
        public void SayHello(string name) 
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void SayHello(string name, string lastName) 
        {
            Console.WriteLine($"Hello, {name} {lastName}");
        }

        public void SayHello(string name, string middleName, string lastName) 
        {
            Console.WriteLine($"Hello, {name} {middleName} {lastName}");
        }

        public void SayHello(string name, string lastName, int age)
        {
            Console.WriteLine($"Hello, {name} {lastName}, you are now {age} years old.");
        }

        public void SayHello(GreetingsOptions options) 
        {
            Console.WriteLine($"Hello, {options.Name} {options.MiddleName} {options.LastName}");
        }
    }
}
