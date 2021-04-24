using SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Bob Bobsky", 44, 38970123123,
                new List<string> { "Javascript", "C#", "Html", "css" }, 6);
            Tester tester = new Tester("Jill Wayne", 32, 38970123123, 540);
            Operations operations = new Operations("Greg Gregsky", 28, 38970123123,
                new List<string> { "Optimus", "ProtoBeat", "PickPro" });
            DevOps devOps = new DevOps("Anne Brown", 23, 38970123321, true, false);
            QAEngineer qAEngineer = new QAEngineer("Mia Wong", 32, 38970321123,
                new List<string> { "Selenium" });

            Console.WriteLine("The Developer:");
            Console.WriteLine(developer.GetInfo());
            developer.Greet("Students");
            developer.Code();

            Console.WriteLine("==========================");

            Console.WriteLine("The Tester: ");
            Console.WriteLine(tester.GetInfo());
            tester.Greet("Students");
            tester.TestFeature("Log in");

            Console.WriteLine("=========================");

            Console.WriteLine("The IT Operations specialist: ");
            Console.WriteLine(operations.GetInfo());
            operations.Greet("Students");
            Console.WriteLine($"Infrastructure OK: {operations.CheckInfrastructure(200)}");

            Console.WriteLine("=========================");

            Console.WriteLine("The DevOps");
            Console.WriteLine(devOps.GetInfo());
            devOps.Greet("Students");
            devOps.Code();
            Console.WriteLine($"Infrastructure OK: {devOps.CheckInfrastructure(200)}");

            Console.WriteLine("=========================");

            Console.WriteLine("The QA engineer");
            Console.WriteLine(qAEngineer.GetInfo());
            qAEngineer.Greet("Students");
            qAEngineer.Code();
            qAEngineer.TestFeature("Order");

            Console.WriteLine("=========================");

            Console.ReadLine();
        }
    }
}
