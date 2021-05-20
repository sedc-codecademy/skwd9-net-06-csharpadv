using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using TryBeingFit.Domain.Helpers;

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
            if(!ValidationHelper.ValidName(firstName))
            {
                throw new Exception("First Name does not met the requirements");
            }

            if (!ValidationHelper.ValidName(lastName))
            {
                throw new Exception("Last Name does not met the requirements");
            }

            if (!ValidationHelper.ValidUsername(username))
            {
                throw new Exception("First Name does not met the requirements");
            }

            if (!ValidationHelper.ValidPassword(password))
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

        //private bool ValidatePassword(string password)
        //{
        //    //if (password.Length < 6)
        //    //    return false;

        //    //if (!password.Any(x => char.IsDigit(x)))
        //    //    return false;

        //    ////if (password.All(x => !char.IsDigit(x)))
        //    ////    return false;

        //    ////if (!Regex.IsMatch(password, @"^-?\d+$")) 
        //    ////    return false;
        //    //return true;

        //    return password.Length > 6 && password.Any(x => char.IsDigit(x));
        //}

        public override string GetInfo()
        {
            return $"{FullName} ({Username}) [{Role}]";
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }

        public void ChangePassword(string password)
        {
            if (!ValidationHelper.ValidPassword(password))
            {
                throw new Exception("Password does not met the requirements");
            }

            Password = password;
        }
    }
}
