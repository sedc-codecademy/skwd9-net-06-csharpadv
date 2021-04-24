using AbstractClassAndInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface.Entities
{
    public class Developer : Human, IDeveloper
    {
        public int YearsExperience { get; set; }
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();

        public Developer()
        {

        }

        public Developer(string fullName, int age, long phone, int yearsExperience, List<string> progLanguages)
            : base(fullName, age, phone)
        {
            YearsExperience = yearsExperience;
            ProgrammingLanguages = progLanguages;
        }

        // have to use override too
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsExperience} years of exprerience";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak.....");
            Console.WriteLine("Opens Stack Overflow.....");
            Console.WriteLine("tak tak tak tak tak.....");
        }
    }
}
