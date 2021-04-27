using SEDC.Class03.Interfaces.ConsoleApp.Models;
using System;

namespace SEDC.Class03.Interfaces.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QA tester1 = new QA("Marko", "Markovski", 26);
            Devops devopsLead = new Devops("Nebojsa", "Zafirovski", 45);
            Console.WriteLine(devopsLead.CheckHTTPRequest(400));
            tester1.Code();
            Developer someDeveloper = new Developer("Petre", "Arsovski", 25);
            someDeveloper.FindTheProject(tester1);
        }
    }
}
