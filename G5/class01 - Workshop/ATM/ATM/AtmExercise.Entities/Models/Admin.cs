using System;
using System.Collections.Generic;
using System.Text;
using AtmExercise.Entities.Enums;

namespace AtmExercise.Entities.Models
{
    public class Admin : User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<DateTime> LoginSessions { get; set; }

        public Admin(string firstName, string lastName, string username, string password) : base(firstName, lastName, Role.Admin)
        {
            Username = username;
            Password = password;
        }

    }
}
