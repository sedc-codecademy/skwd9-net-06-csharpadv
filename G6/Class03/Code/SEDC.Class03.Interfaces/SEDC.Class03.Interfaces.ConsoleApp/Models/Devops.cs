using SEDC.Class03.Interfaces.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.Interfaces.ConsoleApp.Models
{
    public class Devops : Human, IDevops, IDevelop
    {
        public Devops(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public bool IsAWSCertified { get; set; }
        public bool IsAzureCertified { get; set ; }

        public override void CelebrateBirthday()
        {
            Console.WriteLine($"{this.FirstName} celebrates his/birthday");
        }

        public string CheckHTTPRequest(int statusCode)
        {
            switch (statusCode)
            {
                case 200:
                    return "The http response is successfull";
                case 400:
                    return "The http response is not succssesfull";
                default:
                    return "Unknown status code";
            }
        }

        public void Code()
        {
            Console.WriteLine("The devops guy codes");
        }
    }
}
