using System;

namespace GenericsDemo
{
    public class Human : Object
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //public string Print()
        //{
        //    return FullName;
        //}

        public override string ToString()
        {
            return FullName;
        }
    }
}
