using AtmExercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmExercise.Entities.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        
        public User(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
