using AbstractClassAndInterface.Entities;
using System.Collections.Generic;
using System;

namespace AbstractClassAndInterface
{
    class Program
    {
        // a definition of a method consists of:
        // a signature (access modifier, return type, name, pamaters with type)
        // body / implementation
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
        static void Main(string[] args)
        {

            // you cannot instantiate an object from an abstract class
            //Human myFavHuman = new Human();

            #region Instances
            Developer dev = new Developer("Bob Bobsky", 25, 38970111222, 3, new List<string>() { "C#", "PhP", "HTML" });
            Tester tester = new Tester("John Snow", 22, 38977123123, 120);
            DevOps devOps = new DevOps("Roki Balboa", 35, 38978321321, true, false);
            QAEngineer qa = new QAEngineer("Fidancho FIdanovski", 43, 38975123123, 1876, new List<string>() { "Chai", "Selenium" });
            #endregion


            #region Testing methods
            Console.WriteLine("The Developer");
            Console.WriteLine(dev.GetInfo());
            dev.Greet("Marija");
            dev.Code();
            Console.WriteLine("------------------------------");

            Console.WriteLine("The Tester");
            Console.WriteLine(tester.GetInfo());
            tester.Greet("Sanja");
            tester.TestFeature("Sending transaction to Blockchain");
            Console.WriteLine("------------------------------");

            Console.WriteLine("The DevOps");
            Console.WriteLine(devOps.GetInfo());
            devOps.Greet("Pane");
            devOps.CheckInfrastructure(404);
            devOps.Code();
            Console.WriteLine("------------------------------");

            Console.WriteLine("The QA");
            Console.WriteLine(qa.GetInfo());
            qa.Greet("Kiki");
            qa.TestFeature("Buy item from products");
            Console.WriteLine("------------------------------");
            #endregion
            Console.ReadLine();
        }
    }
}
