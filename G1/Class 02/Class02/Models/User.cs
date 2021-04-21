using System;

namespace Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string UserName { get; set; }
        private string Password { get; set; }
        public RoleEnum Role { get; private set; }
        private int FailedLoginAttempts { get; set; }
        public bool Locked => FailedLoginAttempts >= 3;

        public User(string firstName, string lastName, string userName, string password, RoleEnum role)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Role = role;
            FailedLoginAttempts = 0;
        }

        public void UpdatePassword(string oldPassword, string newPassword)
        {
            if (Password != oldPassword)
            {
                throw new Exception("Invalid old password");
            }

            Password = newPassword;
        }

        //public bool ValidPassword(string password)
        //{
        //    if (Locked)
        //    {
        //        throw new Exception("Account is locked");
        //    }

        //    if (Password != password)
        //    {
        //        FailedLoginAttempts++;
        //    }
        //    else
        //    {
        //        FailedLoginAttempts = 0;
        //    }

        //    return Password == password;
        //}

        public User Login(string username, string password)
        {
            if (UserName != username)
            {
                return null;
            }

            if (Locked)
            {
                throw new Exception("Account locked");
            }

            if (Password != password)
            {
                FailedLoginAttempts++;
                throw new Exception("Wrong password");
            }

            FailedLoginAttempts = 0;

            return this;
        }
    }
}
