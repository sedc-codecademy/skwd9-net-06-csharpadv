using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Developer : Person, IDeveloper
    {
        public string Project { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> ProgrammingLanguages { get; set; }
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} has {YearsOfExperience} years of experience and works on {Project}";
        }

        public void Code()
        {
            Console.WriteLine("Coding...");
        }

        public Developer(string firstName, string lastName, int age, long phoneNumber, string project, int experience)
            : base(firstName, lastName, age, phoneNumber)
        {
            Project = project;
            YearsOfExperience = experience;
            ProgrammingLanguages = new List<string>();
        }
    }
}
