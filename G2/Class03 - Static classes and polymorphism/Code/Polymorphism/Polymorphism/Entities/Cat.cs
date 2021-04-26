using System;

namespace Polymorphism.Entities
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public override void Eat()
        {
            Console.WriteLine($"Cat {Name} is eating..");
        }
    }
}
