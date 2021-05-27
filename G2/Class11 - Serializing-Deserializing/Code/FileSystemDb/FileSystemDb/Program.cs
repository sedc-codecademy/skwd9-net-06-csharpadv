using FileSystemDb.Domain;
using FileSystemDb.Domain.Enums;
using System;
using System.Collections.Generic;

namespace FileSystemDb
{
    class Program
    {
        public static Database<Student> StudentsDb = new Database<Student>();
        public static Database<Subject> SubjectsDb = new Database<Subject>();

        public static void Seed()
        {
            if(SubjectsDb.GetAll().Count == 0)
            {
                SubjectsDb.Insert(new Subject()
                {
                    NumOfModules = 10,
                    Title = "C#",
                    Academy = AcademyType.WebDevelopment
                });
                SubjectsDb.Insert(new Subject()
                {
                    NumOfModules = 15,
                    Title = "AJS",
                    Academy = AcademyType.WebDevelopment
                });
            }

            if (StudentsDb.GetAll().Count == 0)
            {
                StudentsDb.Insert(new Student()
                {
                   FirstName = "Ana",
                   LastName = "Markovska",
                   Age = 20 
                });
                StudentsDb.Insert(new Student()
                {
                    FirstName = "Marko",
                    LastName = "Markovski",
                    Age = 22
                });
            }
        }
        static void Main(string[] args)
        {
            //List<Subject> subjects = new List<Subject>();
            //subjects.Add(new Subject()
            //{
            //    Id = 1,
            //    Title = "JS",
            //    Academy = AcademyType.WebDevelopment
            //});
            //subjects.Add(new Subject()
            //{
            //    Id = 2,
            //    Title = "C#",
            //    Academy = AcademyType.WebDevelopment
            //});

            //Database<Subject> subjectsDb = new Database<Subject>();
            //subjectsDb.Write(subjects); //Write is private

            //List<Subject> dbSubjects = subjectsDb.Read(); //Read is private

            Seed();

            List<Student> students = StudentsDb.GetAll();
            foreach(Student student in students)
            {
                Console.WriteLine(student.GetInfo());
            }

            Subject firstSubject = SubjectsDb.GetById(1);
            if(firstSubject != null)
            {
                Console.WriteLine(firstSubject.GetInfo());
            }

            Console.WriteLine("Enter student data:");
            Console.WriteLine("Enter first name");
            
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());

            Student newStudent = new Student();
            newStudent.FirstName = firstName;
            newStudent.LastName = lastName;
            newStudent.Age = age;

            StudentsDb.Insert(newStudent);
            Console.ReadLine();
        }
    }
}
