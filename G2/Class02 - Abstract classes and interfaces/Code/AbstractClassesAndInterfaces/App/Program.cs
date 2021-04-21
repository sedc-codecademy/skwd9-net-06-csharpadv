using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace App
{
	class Program
	{
		public static void HappyBirthday(IPerson person)
        {
			Console.WriteLine($"This is {person.GetInfo()}");
			Console.WriteLine("Happy birthday to you");
        }
		static void Main(string[] args)
		{
			//Person person = new Person("Martin", "Stojanovski", 20, 3647474); - ERROR - abstract class, can not instantiate

			Developer developer = new Developer("Ivana", "Petrevska", 24, 5345435, "ECommerce", 2);
			DevOps devOps = new DevOps("MArko", "Markovski", 30, 767467324, true, false);
			Operations operationsManager = new Operations("Vasil", "Markovski", 28, 767467324, 
				new List<string> { "BetProject", "DentalSystem"});
			QAEngineer qA = new QAEngineer("Ana", "Martinovska", 34, 453454, null);

			Console.WriteLine("Dev:");
			Console.WriteLine(developer.GetInfo());
			Console.WriteLine("DevOps:");
			Console.WriteLine(devOps.GetInfo());
			Console.WriteLine("Ops:");
			Console.WriteLine(operationsManager.GetInfo());
			Console.WriteLine("QA:");
			Console.WriteLine(qA.GetInfo());

			Console.WriteLine("Dev:");
			//from Person
			developer.Goodbye();
			//from IDeveloper
			developer.Code();

			Console.WriteLine("DevOps:");
			//from Person
			devOps.Greet("SEDC");
			//from Person
			devOps.Goodbye();
			//from IDeveloper
			devOps.Code();
			//from IOperations
			Console.WriteLine(devOps.CheckInfrastructure(200));

			HappyBirthday(developer);
			HappyBirthday(qA);

			Console.ReadLine();
		}
	}
}
