using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; }

        public Teacher()
        {
            Subjects = new List<string>();
        }
        public void PrintSubjects()
        {
            Console.WriteLine("Subjects");
            foreach(string subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Teacher {FirstName} {LastName}, teaches {Subjects.Count} subjects");
        }
    }
}
