using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystemDatabase.Entities
{
	public class Student : BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

        public Student(){}

		public Student(string first, string last, int age)
		{
			FirstName = first;
			LastName = last;
			Age = age;
		}

		public override string Info()
		{
			return $"{FirstName} {LastName}, {Age} years old!";
		}
	}
}
