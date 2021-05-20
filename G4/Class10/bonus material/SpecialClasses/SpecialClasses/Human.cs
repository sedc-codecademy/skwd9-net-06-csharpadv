using SpecialClasses.Partial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialClasses
{
    // Human class that has a nested class Address
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int PassCode { get; set; }
        public void Talk(string words)
        {
            Console.WriteLine($"The human {FirstName} is talking {words}!");
        }
        private bool EnterPassCode(int code)
        {
            if (code == PassCode) return true;
            return false;
        }
        // This is a nested class. This does not mean that Human has Address
        // They only live in the same place, meaning that Address can 
        // access private stuff ONLY IF IT HAS AN INSTANCE of human
        public class Address
        {
            public string Street { get; set; }
            public int Number { get; set; }
            public Human Owner { get; set; } // The instance of Human
            public void MoveIn(Human person)
            {
                Owner = person;
                Owner.PassCode = 1234; // We can access PassCode even tho it is private
                Console.WriteLine($"{person.FirstName} has moved in this address!");
            }
            public void EnterHouse(int code)
            {
                // We can access EnterPassCode even tho it is private
                if (Owner.EnterPassCode(code)) Console.WriteLine($"Welcome mister {Owner.FirstName}!");
                else Console.WriteLine("You didn't enter the correct code!");
            }
        }
    }
}
