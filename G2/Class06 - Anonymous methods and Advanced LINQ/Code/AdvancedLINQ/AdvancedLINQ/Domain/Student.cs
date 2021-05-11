using System.Collections.Generic;

namespace AdvancedLINQ.Domain
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
        public List<Subject> Subjects { get; set; }
        public Student(int id, string firstName, string lastName, int age, bool partTime)
        {
            Subjects = new List<Subject>();
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsPartTime = partTime;
        }
        public override string GetInfo()
        {
            string result = $"[{Id}, {FirstName} {LastName}]";
            result += IsPartTime ? " is a part time student " : "";
            return result;
        }
    }
}
