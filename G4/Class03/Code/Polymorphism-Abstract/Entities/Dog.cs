using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstract.Entities
{
    public class Dog : Animal
    {
        public override bool Feathers { get; set; } = false;
        public override string Describe()
        {
            return base.Describe() + ": This is about Dogs.";
        }
        public override string Features()
        {
            return "Can bark.";
        }
        public override bool HasFeathers()
        {
            return Feathers;
        }
        //You cannot declare an abstract method outside an abstract class 
    }
}
