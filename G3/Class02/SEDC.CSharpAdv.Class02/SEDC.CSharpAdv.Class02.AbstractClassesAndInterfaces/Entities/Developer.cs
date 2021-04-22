﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities
{
    public class Developer : Human
    {
        public string Gender { get; set; }
        public List<string> ProgramingLanguages { get; set; }
        public int YearsOfExperiance { get; set; }

        public Developer(string fullname, int age, long phone, List<string> languages, int exp)
            :base(fullname, age, phone)
        {
            ProgramingLanguages = languages;
            YearsOfExperiance = exp;
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
    }
}
