using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismMain.Entities
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Nom nom nom... these mice are tasty!");
        }
    }
}
