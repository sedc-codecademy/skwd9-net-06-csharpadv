using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialClasses
{
    // Class created only to show that you can have 
    // two classes with a nested class of the same name
    public class Company
    {
        public string Name { get; set; }
        public class Address
        {
            public string Street { get; set; }
            public int Number { get; set; }
        }
    }

    // Simple example to show that we can inherit from a nested class
    public class SpecialAddress : Company.Address
    {
        public SpecialAddress()
        {
            Console.WriteLine(Street);
        }
    }
}
