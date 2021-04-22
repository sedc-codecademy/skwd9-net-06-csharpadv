using System;
using System.Collections.Generic;
using System.Text;

namespace Models.UserFolder
{
    public class Student : User
    {
        public bool DoneTest { get; set; }
        public Nullable<int> Grade { get; set; } //int?
        public Student() : base(Role.Student) { }
        public Student(string usern, string pass) : base(Role.Student)
        {
            DoneTest = false;
            Username = usern;
            Password = pass;
        }

    }
}
