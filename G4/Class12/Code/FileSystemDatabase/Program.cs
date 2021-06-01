using FileSystemDatabase.Entities;
using System;
using System.Collections.Generic;

namespace FileSystemDatabase
{
    class Program
    {
        static Db<Student> _studentDb = new Db<Student>();
        static Db<Subject> _subjectDb = new Db<Subject>();

		// Method that insert some initial data in the database
		static void Seed()
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
            Console.WriteLine("========== TESTING ===========");
			List<Subject> subjects = _subjectDb.GetAll();
			List<Student> students = _studentDb.GetAll();

			Console.WriteLine("========== GET ALL ===========");
			students.ForEach(x => Console.WriteLine(x.Info()));
			subjects.ForEach(x => Console.WriteLine(x.Info()));

			Console.WriteLine("========== GET BY ID ===========");
            Console.WriteLine(_studentDb.GetById(2).Info());
            Console.WriteLine(_subjectDb.GetById(1).Info());
			Console.ReadLine();

			Console.Clear();
			// Insert student by inputs
			Console.WriteLine("========== CREATE NEW USER ===========");
			Console.WriteLine("Enter First Name: ");
			string first = Console.ReadLine();
			Console.WriteLine("Enter Last Name: ");
			string last = Console.ReadLine();
			Console.WriteLine("Enter Age: ");
			int age = int.Parse(Console.ReadLine());
			Student student = new Student(first, last, age);
			_studentDb.Insert(student);
			Console.WriteLine("======= STUDENT CREATED =======");
			Console.ReadLine();

			Console.WriteLine("========== GET ALL AGAIN ===========");
			_studentDb.GetAll().ForEach(x => Console.WriteLine(x.Info()));
			Console.ReadLine();

			Console.WriteLine("========== DELETING DATABASES ===========");
			Console.WriteLine("You want to clear both DB? ( y/n )");
			string answer = Console.ReadLine();
			if (answer.ToLower() == "y")
			{
				_studentDb.ClearDb();
				_subjectDb.ClearDb();
			}
			else
			{
				Console.WriteLine("I guess not. Goodbye!");
			}

			Console.ReadLine();
        }
    }
}
