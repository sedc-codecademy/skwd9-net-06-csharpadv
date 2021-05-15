using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AdvancedLINQ.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {

        }
        public Student(int id, string firstName, string lastName, int age, bool partTime)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsPartTime = partTime;
        }

        public override string Info()
        {
            string result = $"{Id}. {FirstName} {LastName} - {Age} years old!";
            result += IsPartTime ? "A part time student!" : "";
            return result;
        }
    }
}
