using ClassExercise.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise.Entities.Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();

        public Teacher()
        {
                
        }

        public Teacher(int id, string name, string username, string pass, List<string> subjects)
            : base(id, name, username, pass)
        {
            Subjects = subjects;
        }

        public void PrintSubjects()
        {
            Subjects.ForEach(x => Console.WriteLine(x));
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Teacher: {Name} with {Username} teaches {Subjects.Count} subjects.");
        }

        public void Teach()
        {
            Console.WriteLine("I am teaching all day long!!!");
        }
    }
}
