using Exercise.Domain.Enums;
using System.Collections.Generic;

namespace Exercise.Domain
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastname, int age, Job job)
        {
            FirstName = firstName;
            LastName = lastname;
            Age = age;
            Occupation = job;
            Dogs = new List<Dog>();
        }
    }
}
