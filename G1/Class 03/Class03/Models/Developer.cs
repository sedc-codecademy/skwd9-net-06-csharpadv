using Models.Interfaces;
using System.Collections.Generic;

namespace Models
{
    public class Developer : Human, IDeveloper
    {
        public List<string> ProgrammingLanguages { get; set; }
        public int YearsExperience { get; set; }

        public Developer(string firstName, string lastName, long phone, List<string> languages, int experience) : base(firstName, lastName, phone)
        {
            ProgrammingLanguages = languages;
            YearsExperience = experience;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Phone} - {YearsExperience} years of experience";
        }

        public string Codeing()
        {
            return $"I am coding in my favourite languages {string.Join(",", ProgrammingLanguages)}";
        }
    }
}
