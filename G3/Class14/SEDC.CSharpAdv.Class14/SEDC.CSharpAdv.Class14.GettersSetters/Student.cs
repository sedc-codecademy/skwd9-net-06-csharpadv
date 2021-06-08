using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class14.GettersSetters
{
    public class Student
    {
        // before c# 3 geters and setters
        private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        // aftef c# 3 geters and setters
        private bool _isWorking;
        public bool IsWorking 
        { 
            get
            {
                return _isWorking;
            }
            set 
            {
                _isWorking = value;
            } 
        }

        private Subject _subject;
        public Subject Subject 
        { 
            get 
            {
                return _subject; 
            } 
            set 
            {
                if(_subject == null)
                {
                    _subject = value;
                }
                else
                {
                    throw new ArgumentException("Subject is already assing to this student");
                }
            } 
        }

        public DateTime DateOfBirth { get; set; }

        // public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

        // autoimatic predefined properties
        public string FullName { get; set; }

        public int Age { get; private set; }

        public Student(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
