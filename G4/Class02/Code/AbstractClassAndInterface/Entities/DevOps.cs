using AbstractClassAndInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface.Entities
{
    public class DevOps : Human, IOperations, IDeveloper
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }

        public DevOps()
        {

        }
        public DevOps(string fullName, int age, long phone, bool aws, bool azure)
            : base(fullName, age, phone)
        {
            AWSCertified = aws;
            AzureCertified = azure;
        }
        public void CheckInfrastructure(int status)
        {
            switch (status)
            {
                case 200:
                    Console.WriteLine("OK");
                    break;
                case 404:
                    Console.WriteLine("NotFound");
                    break;
                case 500:
                    Console.WriteLine("Internal Server Error!");
                    break;
                default:
                    Console.WriteLine("Something went wrong :)");
                    break;
            }
        }

        public override string GetInfo()
        {
            string result = $"{FullName} ({Age}) - Has: ";
            result += AWSCertified ? "AWS Certificate" : "";
            result += AzureCertified ? "Azure Certificate" : "";
            return result;
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak.....");
            Console.WriteLine("Opens Stack Overflow.....");
            Console.WriteLine("tak tak tak tak tak.....");
        }
    }
}
