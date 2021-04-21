using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ClassExercise.Entities.Interfaces;

namespace ClassExercise.Entities.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();

        public Student()
        {

        }

        public Student(int id, string name, string username, string pass, List<int> grades)
            : base(id, name, username, pass)
        {
            Grades = grades;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Student: {Name} with username {Username} has average {Grades.Average()} grade.");
        }

        public void SkipWorkshops()
        {
            Console.WriteLine("I hate workshops and Kristina is scarry!");
        }
    }
}
