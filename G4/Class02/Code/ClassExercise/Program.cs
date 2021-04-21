using ClassExercise.Entities.Models;
using System;
using System.Collections.Generic;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student01 = new Student(1, "Pane Manaskov", "pane123", "netikazuvam", new List<int>() { 6, 10, 9 });
            student01.PrintInfo();
            student01.SkipWorkshops();

            Console.WriteLine("------------------------");

            Teacher teacher = new Teacher(2, "Kristina Spasevska", "kiki123", "tajnae", new List<string>() { "HTML", "JS", "C#" });
            teacher.PrintInfo();
            teacher.Teach();

            Console.ReadLine();
        }
    }
}
