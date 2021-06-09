using SEDC.TryBeingFit.Domain.Core.Models;
using SEDC.TryBeingFit.Domain.Db;
using SEDC.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDb<T> _db;

        public UserService()
        {
            _db = new LocalDb<T>();
        }

        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            T user = _db.GetById(userId);
            if(ValidationHelper.ValidateName(firstName, 2) == null || ValidationHelper.ValidateName(lastName, 2) == null)
            {
                MessageHelper.PrintMessage("[Error] Strings were not valid. Please try again!", ConsoleColor.Red);
                return;
            }
            user.FirstName = firstName;
            user.LastName = lastName;
            MessageHelper.PrintMessage("Data successfully changed!", ConsoleColor.Green);
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T user = _db.GetById(userId);
            if(user.Password != oldPassword)
            {
                MessageHelper.PrintMessage("[Error] Old password did not match! Try again!", ConsoleColor.Red);
                return;
            }
            if(ValidationHelper.ValidatePassword(newPassword) == null)
            {
                MessageHelper.PrintMessage("[Error} New password is not valid! Please add minimum 6 characters including one digit!", ConsoleColor.Red);
                return;
            }
            user.Password = newPassword;
            MessageHelper.PrintMessage("Password successfully changed!", ConsoleColor.Green);
        }

        public T GetUserById(int id)
        {
            return _db.GetById(id);
        }

        public T LogIn(string username, string password)
        {
            T user = _db.GetAll().SingleOrDefault(x => x.UserName == username && x.Password == password);
            if(user == null)
            {
                MessageHelper.PrintMessage("[Error] Username or password did not match!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }
            return user;
        }

        public T Register(T user)
        {
            if(ValidationHelper.ValidateName(user.FirstName, 2) == null || 
               ValidationHelper.ValidateName(user.LastName, 2) == null || 
               ValidationHelper.ValidateName(user.UserName, 6) == null || 
               ValidationHelper.ValidatePassword(user.Password) == null)
            {
                MessageHelper.PrintMessage("[Error] Invalid info for the user! Try again!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }
            int id = _db.Insert(user);
            return _db.GetById(id);
        }
    }
}
