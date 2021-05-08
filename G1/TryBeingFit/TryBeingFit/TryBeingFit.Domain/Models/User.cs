using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;
using System;

namespace TryBeingFit.Domain.Models
{
    public abstract class User : BaseEntity, IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Username { get; set; }
        private string Password { get; set; }
        public UserRole Role { get; set; }

        public User(string firstName, string lastName, string username, string password, UserRole role)
        {
            if(firstName.Length < 3)
            {
                throw new Exception("First Name does not met the requirements");
            }

            if (lastName.Length < 3)
            {
                throw new Exception("Last Name does not met the requirements");
            }

            if (username.Length < 6)
            {
                throw new Exception("First Name does not met the requirements");
            }

            if (!ValidatePassword(password))
            //if (!(password.Length > 6 && password.Any(x => char.IsDigit(x))))
            {
                throw new Exception("Password does not met the requirements");
            }

            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Role = role;
        }

        private bool ValidatePassword(string password)
        {
            //if (password.Length < 6)
            //    return false;

            //if (!password.Any(x => char.IsDigit(x)))
            //    return false;

            ////if (password.All(x => !char.IsDigit(x)))
            ////    return false;

            ////if (!Regex.IsMatch(password, @"^-?\d+$")) 
            ////    return false;
            //return true;

            return password.Length > 6 && password.Any(x => char.IsDigit(x));
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Username}) [{Role}]";
        }
    }
}
