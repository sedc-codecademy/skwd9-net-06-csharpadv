using SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities
{
    public class Developer : Human, IDeveloper
    {
        public string Gender { get; set; }
        public List<string> ProgramingLanguages { get; set; }
        public int YearsOfExperiance { get; set; }
        public int Id { get; set; }

        public Developer(string fullname, int age, long phone, List<string> languages, int exp)
            :base(fullname, age, phone)
        {
            ProgramingLanguages = languages;
            YearsOfExperiance = exp;
            Gender = "male";
        }

        public override string GetInfo()
        {
            // mr. mrs. dr.
            if (Gender == "male")
            {
                return $"Mr. {FullName} ({Age}) - {YearsOfExperiance} years of experiance! Has knowledge of {ProgramingLanguages.Count} languages";
            }
            return $"Mrs. {FullName} ({Age}) - {YearsOfExperiance} years of experiance! Has knowledge of {ProgramingLanguages.Count} languages";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("*Opens Stack and Overflow...");
            Console.WriteLine("tak tak tak tak tak....");
        }
    }
}
