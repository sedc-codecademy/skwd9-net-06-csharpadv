using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismMain.Entities
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I ate your slippers!");
        }
    }
}
