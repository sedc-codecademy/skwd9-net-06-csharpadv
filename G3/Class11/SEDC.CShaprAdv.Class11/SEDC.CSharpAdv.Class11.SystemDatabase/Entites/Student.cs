using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class11.SystemDatabase.Entites
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string fname, string lname, int age)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
        }

        public override string Info()
        {
            return $"{FirstName} {LastName}, {Age} years old!";
        }
    }
}
