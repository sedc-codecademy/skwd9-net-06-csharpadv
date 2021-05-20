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
        private IDbTable<T> _table;

        public UserService()
        {
            if (typeof(T) == typeof(StandardUser))
            {
                _table = (IDbTable<T>) LocalDatabase.StandardUsers;
            }
            if (typeof(T) == typeof(PremiumUser))
            {
                _table = (IDbTable<T>) LocalDatabase.PremiumUsers;
            }
            if (typeof(T) == typeof(TrainerUser))
            {
                _table = (IDbTable<T>) LocalDatabase.TrainerUsers;
            }
        }

        public T Login(string username, string password)
        {
            T user = _table.GetAll().FirstOrDefault(x => x.Username == username && x.CheckPassword(password));

            if (user == null)
            {
                throw new Exception("[ERROR] Username or Password is incorrect");
            }

            return user;
        }

        public T Register(T user)
        {
            if (!ValidationHelper.ValidName(user.FirstName) ||
                !ValidationHelper.ValidName(user.LastName) ||
                !ValidationHelper.ValidUsername(user.Username))
            {
                throw new Exception("[ERROR] Invalid parameters");
            }


            _table.Insert(user);
            return user;
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            User user = _table.GetAll().FirstOrDefault(x => x.Id == userId);

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
            User user = _table.GetAll().FirstOrDefault(x => x.Id == userId);

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
