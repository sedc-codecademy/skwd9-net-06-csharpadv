using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstract.Entities
{
    public abstract class Animal
    {
        public abstract bool Feathers { get; set; }
        //You can define and implement a virtual method in abstract classes
        public virtual string Describe()
        {
            return "Basic info about Animals.";
        }
        //Can only define an abstract method, but without implementation
        public abstract string Features();
        public abstract bool HasFeathers();
    }
}
