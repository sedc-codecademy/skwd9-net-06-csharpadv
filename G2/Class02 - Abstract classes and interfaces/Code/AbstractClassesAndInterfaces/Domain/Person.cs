using Domain.Interfaces;
using System;

namespace Domain
{
    //has no instances
    public abstract class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }
        //public string Nationality { get; set; }

        //has no implementation. Must have implementation in the inherited classes. Can not be private!!!
        public abstract string GetInfo();

        //common
        public void Greet(string name)
        {
            Console.WriteLine($"Hello {name}. I am {FirstName} {LastName}");
        }

        public void Goodbye()
        {
            Console.WriteLine($"Goodbye from {FirstName} {LastName}");
        }

        public Person(string firstName, string lastName, int age, long phoneNumber)
        {
            //validation - to do
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}
