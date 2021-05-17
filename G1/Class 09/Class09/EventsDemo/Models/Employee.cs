using System;

namespace EventsDemo.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int YearsOfExperience { get; set; }

        public Employee(string firstName, string lastName, int yearsOfExperience)
        {
            FirstName = firstName;
            LastName = lastName;
            YearsOfExperience = yearsOfExperience;
        }

        public void NotificationSubscriber(string message, string marketName)
        {
            Console.WriteLine($"Hey {FullName} important message from {marketName}: {message}");
        }
    }
}
