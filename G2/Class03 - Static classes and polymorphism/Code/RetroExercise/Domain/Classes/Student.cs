﻿using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Classes
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student()
        {
            Grades = new List<int>();
        }
        public void PrintGrades()
        {
            Console.WriteLine("Grades:");
            foreach(int grade in Grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine();
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, average grade: {Grades.Sum() / (double)Grades.Count}");
        }
    }
}
