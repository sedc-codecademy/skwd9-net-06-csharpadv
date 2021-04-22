using SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities
{
    public class DevOps : Human, IDeveloper, IOperations
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }

        public DevOps(string fullname, int age, long phone, bool awscert, bool azurecert)
            :base(fullname, age, phone)
        {
            AWSCertified = awscert;
            AzureCertified = azurecert;
        }

        public override string GetInfo()
        {
            string result = $"{FullName} ({Age}) - Has: ";
            result += AWSCertified ? "Aws certificate" : "";
            result += AzureCertified ? "Azure certificate" : "";
            result += AWSCertified || AzureCertified ? "" : "No certificates yet";
            return result;
        }

        public bool CheckInfrastructure(int status)
        {
            List<int> validStatuses = new List<int> { 200, 202, 204 };
            return validStatuses.Contains(status);
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("*Opens Stack Excahnge DevOps...");
            Console.WriteLine("tak tak tak tak tak....");
        }
    }
}
