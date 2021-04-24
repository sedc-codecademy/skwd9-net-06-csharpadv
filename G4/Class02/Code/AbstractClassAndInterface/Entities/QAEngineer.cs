using AbstractClassAndInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface.Entities
{
    public class QAEngineer : Human, ITester, IDeveloper
    {
        public List<string> TestingFrameworks { get; set; } = new List<string>();
        public int BugsFound { get ; set; }

        public QAEngineer()
        {

        }

        public QAEngineer(string fullName, int age, long phone, int bugs, List<string> testingFrameworks)
            : base(fullName, age, phone)
        {
            BugsFound = bugs;
            TestingFrameworks = testingFrameworks;
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak.....");
            Console.WriteLine("Opens Stack Overflow.....");
            Console.WriteLine("tak tak tak tak tak.....");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - found {BugsFound} bugs in your code :)";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Run unit tests....");
            Console.WriteLine("Run automated tests....");
            Console.WriteLine($"Tests for the {feature} feature are done!");
        }
    }
}
