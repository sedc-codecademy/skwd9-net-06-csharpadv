using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Operations : Person, IOperations
    {
        public List<string> Projects { get; set; }

        public override string GetInfo()
        {
            string projectsMessage = "";
            try
            {
                foreach (string project in Projects)
                {
                    projectsMessage += $" {project} ";
                }
            }
            catch(NullReferenceException e)
            {
                projectsMessage = " no projects ";
            }
            return $"{FirstName} {LastName} works on \n {projectsMessage}";
        }

        public bool CheckInfrastructure(int status)
        {
            Console.WriteLine("Checking infrastructure..");
            return true;
        }

        public Operations(string firstName, string lastName, int age, long phoneNumber, List<string> projects)
             : base(firstName, lastName, age, phoneNumber)
        {
            Projects = projects;
        }
    }
}
