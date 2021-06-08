using System.Collections.Generic;
using MapperDemo.DomainModels;

namespace MapperDemo.Database
{
    public static class Storage
    {
        public static List<Subject> Subjects = new List<Subject>
        {
            new Subject
            {
                Name = "C# Basic",
                NumberOfClasses = 40
            },
            new Subject
            {
                Name = "C# Advance",
                NumberOfClasses = 60
            }
        };

        public static List<Student> Students = new List<Student>
        {
            new Student
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                Age = 32,
                Subjects = new List<Subject> {Subjects[0], Subjects[1]}
            },
            new Student
            {
                FirstName = "Test",
                LastName = "Test",
                Age = 20,
                Subjects = new List<Subject> {Subjects[1]}
            },
            new Student
            {
                FirstName = "1",
                LastName = "1",
                Age = 1,
                Subjects = new List<Subject> {Subjects[0], Subjects[1]}
            },
            new Student
            {
                FirstName = "2",
                LastName = "2",
                Age = 2,
                Subjects = new List<Subject> {Subjects[1]}
            },
            new Student
            {
                FirstName = "3",
                LastName = "3",
                Age = 3,
                Subjects = new List<Subject> {Subjects[0], Subjects[1]}
            },
            new Student
            {
                FirstName = "4",
                LastName = "4",
                Age = 4,
                Subjects = new List<Subject> {Subjects[1]}
            }
        };
    }
}
