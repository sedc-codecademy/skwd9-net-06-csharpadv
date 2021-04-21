using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class DevOps : Person, IDeveloper, IOperations
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }
        public DevOps(string firstName, string lastName, int age, long phoneNumber, bool aws, bool azure)
             : base(firstName, lastName, age, phoneNumber)
        {
            AWSCertified = aws;
            AzureCertified = azure;
        }
        //Person
        public override string GetInfo()
        {
            string awsCertified = AWSCertified ? "has AWS certificate" : "does not have AWS certificate ";
            string azureCertified = AzureCertified ? "has Azure certificate" : "does not have Azure certificate ";
            return $"{FirstName} {LastName} {awsCertified}, {azureCertified}";
        }

        //IDeveloper
        public void Code()
        {
            Console.WriteLine("DevOps is coding...");
        }

        //IOperations
        public bool CheckInfrastructure(int status)
        {
            if (status >= 200 && status <= 299)
                return true;
            return false;
        }
    }
}
