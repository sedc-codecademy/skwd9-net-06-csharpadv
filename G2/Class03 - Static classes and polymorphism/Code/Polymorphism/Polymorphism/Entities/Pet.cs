using System;

namespace Polymorphism.Entities
{
    public class Pet
    {
        public string Name { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine($"Pet {Name} is eating..");
        }
    }
}
