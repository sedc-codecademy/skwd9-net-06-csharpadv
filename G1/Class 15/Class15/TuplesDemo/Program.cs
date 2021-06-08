using System;
using System.Collections.Generic;

namespace TuplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Risto", "Panchevski");

            //// valid from C# 9.0+
            ////Student student1 = new ("Risto", "Panchevski");

            ////student.Subjects.Add("C# Advance");
            ////student.Subjects.Add("C# Basic");

            //student.Subjects.AddRange(new List<string> { "C# Advance", "C# Basic" });

            //List<Student> listStudent = new List<Student>();
            //listStudent.Add(student);

            //Console.WriteLine($"{student.FirstName} {student.LastName} {string.Join(", ", student.Subjects)}");

            Tuple<string, string, List<string>> student =
                new Tuple<string, string, List<string>>("Risto", "Panchevski", new List<string>());

            student.Item3.AddRange(new List<string> { "C# Advance", "C# Basic" });

            Console.WriteLine($"{student.Item1} {student.Item2} {string.Join(", ", student.Item3)}");

            //List<Tuple<string, string, List<string>>> listStudent = 
            //    new List<Tuple<string, string, List<string>>>();
            //listStudent.Add(student);

            List<Tuple<string, string, List<string>>> listStudent =
                new List<Tuple<string, string, List<string>>>
                {
                    student
                };
        }
    }

    //public class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public List<string> Subjects { get; set; }

    //    public Student(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}
