using SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities
{
    public class QAEngineer : Human, IDeveloper, ITester
    {
        public List<string> TestingFrameworks { get; set; }

        public QAEngineer(string fullname, int age, long phone, List<string> frameworks)
            : base(fullname, age, phone)
        {
            TestingFrameworks = frameworks;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Knows {(TestingFrameworks.Count != 0 ? TestingFrameworks[0] : "unknown")} frameworks!";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Run Unit tests...");
            Console.WriteLine("Run Automaated tests...");
            Console.WriteLine($"Tests for the {feature} feature are done!");
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("*Opens Stack and Overflow QA...");
            Console.WriteLine("tak tak tak tak tak....");
        }
    }
}
