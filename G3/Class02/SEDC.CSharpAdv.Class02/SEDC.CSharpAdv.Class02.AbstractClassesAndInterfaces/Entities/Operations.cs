using SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; }

        public Operations(string fullname, int age, long phone, List<string> projects)
            :base(fullname, age, phone)
        {
            Projects = projects;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - currenty working on {Projects.Count} projects";
        }

        public bool CheckInfrastructure(int status)
        {
            if (status.ToString().StartsWith("4"))
            {
                return false;
            }
            return true;
        }
    }
}
