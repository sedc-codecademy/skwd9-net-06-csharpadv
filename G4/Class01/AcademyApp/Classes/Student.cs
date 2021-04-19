using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student : Person
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, int> PreviousSubjects {get; set; }
        public Student(string firstName, string lastName, string userName, string password, Dictionary<Subject, int> previousSubjects) : base(Role.Student, firstName, lastName, userName, password)
        {
            this.PreviousSubjects = previousSubjects;
        }
        public void Enroll(Subject sub)
        {
            this.CurrentSubject = sub;
        }

        public string GetInfo()
        {
            string info = String.Empty;
            foreach (var item in this.PreviousSubjects)
            {
                info += $"{item.Key.Name}: {item.Value} \n";
            }
            return info;
        }
    }
    
}
