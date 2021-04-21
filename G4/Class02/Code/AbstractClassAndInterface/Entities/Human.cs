using AbstractClassAndInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface.Entities
{
    public abstract class Human : IHuman
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public long Phone { get; set; }


        public Human()
        {

        }

        public Human(string fullName, int age, long phone)
        {
            FullName = fullName;
            Age = age;
            Phone = phone;
        }

        // a method with an implementation
        // we add implementation - from the IHuman
        public void Greet(String name)
        {
            Console.WriteLine($"Hay there {name}! My name is {FullName}");
        }

        // a method without implementation
        // have to user the keyword abstract
        // if we don't user abstract, we have to add implementation
        public abstract string GetInfo();

    }
}
