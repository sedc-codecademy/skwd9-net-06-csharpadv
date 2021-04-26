using Models;
using System.Collections.Generic;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human h = new Human("Risto", "Pan", 1013123);

            Developer dev = new Developer("Bob", "Bobsky", 1234567, new List<string> { "C#", "JS", "Java" }, 5);
            Tester tester = new Tester("Tester", "Tester", 23423423, 10);
            QaEngineer qaEngineer = new QaEngineer("QA", "Engineer", 34234242, new List<string> { "Selenium", "Junit" });
            DevOps devOps = new DevOps("Cloud", "DevOps", 123123123, true, false);
            Operations operations = new Operations("Local", "Operations", 123123123, 50);

            Console.WriteLine("Developer:");
            Console.WriteLine(dev.GetInfo());
            Console.WriteLine(dev.Greetings("Risto"));
            Console.WriteLine(dev.Codeing());


            Console.WriteLine("Tester:");
            Console.WriteLine(tester.GetInfo());
            Console.WriteLine(tester.Greetings("Risto"));
            Console.WriteLine(tester.Testing());

            Console.WriteLine("QaEngineer:");
            Console.WriteLine(qaEngineer.GetInfo());
            Console.WriteLine(qaEngineer.Greetings("Risto"));
            Console.WriteLine(qaEngineer.Testing());
            Console.WriteLine(qaEngineer.Codeing());

            Console.WriteLine("DevOps:");
            Console.WriteLine(devOps.GetInfo());
            Console.WriteLine(devOps.Greetings("Risto"));
            Console.WriteLine(devOps.CheckInfrastructure("Failed"));
            Console.WriteLine(devOps.Codeing());

            Console.WriteLine("Operations:");
            Console.WriteLine(operations.GetInfo());
            Console.WriteLine(operations.Greetings("Risto"));
            Console.WriteLine(operations.CheckInfrastructure("Ok"));
        }
    }
}
