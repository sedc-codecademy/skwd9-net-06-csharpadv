﻿using Domain.Classes;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student()
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Peterson",
                Username = "BobP",
                Password = "123",
                Grades = new List<int>() { 1, 4, 5 }
            };

            Student marry = new Student()
            { 
                Id = 2,
                FirstName = "Marry",
                LastName = "Peterson",
                Username = "MarryP",
                Password = "123",
                Grades = new List<int>() { 2, 3, 1, 4, 5 }
            };

            Teacher anne = new Teacher()
            {
                Id = 3,
                FirstName = "Anne",
                LastName = "Peterson",
                Username = "AnneP",
                Password = "123",
                Subjects = new List<string> { "HTML", "BasicJS", "BasicCSharp" }
            };

            Teacher patrick = new Teacher()
            {
                Id = 4,
                FirstName = "Patrick",
                LastName = "Peterson",
                Username = "PatrickP",
                Password = "123",
                Subjects = new List<string> { "HTML", "BasicJS", "AJS", "BasicCSharp" }
            };

            anne.PrintUser();
            marry.PrintUser();
            marry.PrintGrades();
            patrick.PrintSubjects();
            Console.ReadLine();
        }
    }
}
