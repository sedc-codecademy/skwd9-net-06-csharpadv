using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class QAEngineer : Person, IDeveloper, ITester
    {
        public List<string> TestingFrameworks { get; set; }
        public QAEngineer(string firstName, string lastName, int age, long phoneNumber, List<string> testingFramewroks)
             : base(firstName, lastName, age, phoneNumber)
        {
            TestingFrameworks = testingFramewroks;
        }

        public override string GetInfo()
        {
            try
            {
                return $"{FirstName} {LastName} knows {TestingFrameworks.Count} frameworks";
            }
            catch (NullReferenceException)
            {
                return $"{FirstName} {LastName} knows 0 frameworks";
            }
        }

        public void Code()
        {
            Console.WriteLine("QA is coding...");
        }

        public void TestFeatures()
        {
            Console.WriteLine("Testing features...");
        }
    }
}
