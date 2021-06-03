using FileSystemDatabase.Entities;
using FileSystemDatabase.Enums;
using System;
using System.Collections.Generic;

namespace FileSystemDatabase
{
    class Program
    {
        public static Db<Student> _studentDb = new Db<Student>();
        public static Db<Subject> _subjectDb = new Db<Subject>();

        public static void Seed() 
        {
			// Check if inserting works
			// If the databases are empty, only then this will insert the initial data
			if (_studentDb.GetAll().Count == 0)
			{
				Console.WriteLine("======= INSERTING STUDENTS =======");

				_studentDb.Insert(new Student("Bob", "Bobsky", 25));
				_studentDb.Insert(new Student("Jill", "Wayne", 29));
				_studentDb.Insert(new Student("Greg", "Gregsky", 36));
			}

			if (_subjectDb.GetAll().Count == 0)
			{
				Console.WriteLine("======= INSERTING SUBJECTS =======");
				_subjectDb.Insert(new Subject("C# Basic", Academy.Code, 40));
				_subjectDb.Insert(new Subject("Introduction to Servers", Academy.Networks, 32));
				_subjectDb.Insert(new Subject("Photoshop", Academy.Design, 60));
			}
		}

        static void Main(string[] args)
        {
			Seed();

			// Check if GetAll work
			List<Student> students = _studentDb.GetAll();
			List<Subject> subjects = _subjectDb.GetAll();

			students.ForEach(student => Console.WriteLine(student.Info()));
			subjects.ForEach(subject => Console.WriteLine(subject.Info()));

			// Check if GetById works
			Subject sub1 = _subjectDb.GetById(1);
			Console.WriteLine(sub1.Info());

			Student viktor = new Student()
			{
				FirstName = "Viktor",
				LastName = "Jakovlev",
				Age = 31
			};

			// Check if Insert works
			_studentDb.Insert(viktor);

			Console.WriteLine("Do you want to clear both Databases? (y/n)");
			string answer = Console.ReadLine();

			if (answer.ToLower() == "y")
			{
				// Check if ClearDb works
				_studentDb.ClearDb();
				_subjectDb.ClearDb();
			}
			else 
			{
				Console.WriteLine("Ok, bye!");
			}

		}
    }
}
