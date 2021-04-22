using System;
using System.Collections.Generic;
using System.Text;

namespace Models.UserFolder
{
    public class Teacher : User
    {
        public Teacher() : base(Role.Teacher) { }
        public Teacher(string usern, string pass) : base(Role.Teacher)
        {
            Username = usern;
            Password = pass;
        }
    }
}
