using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.Polymorphisam.Entites
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Nom nom nom on cat food");
        }
    }
}
