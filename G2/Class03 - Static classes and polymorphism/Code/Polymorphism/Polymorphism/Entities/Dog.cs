using System;

namespace Polymorphism.Entities
{
    public class Dog : Pet
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine($"Dog {Name} is eating..");
        }
    }
}
