using Polymorphism_Abstract.Entities;
using System;

namespace Polymorphism_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Dogs ---");
            Dog d = new Dog();
            Console.WriteLine(d.Describe());
            Console.WriteLine(d.Features());
            Console.WriteLine($"Has feathers: {d.HasFeathers()}"); //get info from method
            Console.WriteLine($"Has feathers: {d.Feathers}"); //get info from property
            Console.WriteLine();

            Console.WriteLine("--- Birds ---");
            Bird b = new Bird();
            Console.WriteLine(b.Describe());
            Console.WriteLine(b.Features());
            Console.WriteLine($"Has feathers: {b.HasFeathers()}");
            Console.WriteLine($"Has feathers: {b.Feathers}");

            Console.ReadLine();
        }
    }
}
