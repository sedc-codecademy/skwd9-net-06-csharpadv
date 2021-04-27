using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.Polymorphisam.Entites
{
    public class Pet
    {
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Nom nom nom");
        }
    }
}
