using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorphism.Entities
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Cat is eating cat food!");
        }

    }
}
