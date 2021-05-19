using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TryBeingFit.Domain.Database;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Helpers;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private List<User> _table;

        public UserService()
        {
            if (typeof(T) is StandardUser)
            {
                _table = LocalDatabase.StandardUsers.GetAll().Select(x => (User)x).ToList();
            }
            if (typeof(T) is PremiumUser)
            {
                _table = LocalDatabase.PremiumUsers.GetAll().Select(x => (User)x).ToList();
            }
            if (typeof(T) is TrainerUser)
            {
                _table = LocalDatabase.TrainerUsers.GetAll().Select(x => (User)x).ToList();
            }
        }

        public User Login(string username, string password)
        {
            User user = _table.FirstOrDefault(x => x.Username == username && x.CheckPassword(password));

            if (user == null)
            {
                throw new Exception("[ERROR] Username or Password is incorrect");
            }

            return user;
        }

        public User Register(User user)
        {
            if (!ValidationHelper.ValidName(user.FirstName) ||
                !ValidationHelper.ValidName(user.LastName) ||
                !ValidationHelper.ValidUsername(user.Username))
            {
                throw new Exception("[ERROR] Invalid parameters");
            }


            _table.Add(user);
            return user;
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            User user = _table.FirstOrDefault(x => x.Id == userId);

            if (user == null)
            {
                throw new Exception("[ERROR] User with that Id does not exist");
            }

            if (!user.CheckPassword(oldPassword))
            {
                throw new Exception("[ERROR] Incorrect password");
            }

            if (!ValidationHelper.ValidPassword(newPassword))
            {
                throw new Exception("Password does not met the requirements");
            }

            user.ChangePassword(newPassword);
        }

        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            User user = _table.FirstOrDefault(x => x.Id == userId);

            if (user == null)
            {
                throw new Exception("[ERROR] User with that Id does not exist");
            }

            if (!ValidationHelper.ValidName(firstName) ||
                !ValidationHelper.ValidName(lastName))
            {
                throw new Exception("Invalid user info");
            }

            user.FirstName = firstName;
            user.LastName = lastName;
        }
    }
}
