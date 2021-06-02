using SEDC.TryBeingFit.Domain.Core.Entities;
using SEDC.TryBeingFit.Domain.Db;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDb<T> _db;

        public UserService()
        {
            // This is the code where everything works with local DB
            //_db = new LocalDb<T>();

            // now we work with file system DB
            _db = new FileSystemDb<T>();
        }
        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T user = _db.GetById(userId);
            if (user.Password != oldPassword)
            {
                MessageHelper.Color("[Error] Old password did not match", ConsoleColor.Red);
                Console.ReadLine();
                return;
            }
            if (ValidationHelper.ValidatePassword(newPassword) == null)
            {
                MessageHelper.Color("[Error] New password is not valid", ConsoleColor.Red);
                Console.ReadLine();
                return;
            }
            user.Password = newPassword;
            _db.Update(user);
            MessageHelper.Color("Password successfully changed!", ConsoleColor.Green);
            Console.ReadLine();
        }

        public T GetById(int id)
        {
            return _db.GetById(id);
        }

        public bool IsDbEmpty()
        {
            return _db.GetAll().Count == 0;
        }

        public T Login(string username, string password)
        {
            T user = _db.GetAll()
                    .SingleOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                MessageHelper.Color("[Error] Username or password did not match!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }
            return user;
        }

        public T Register(T user)
        {
            if (ValidationHelper.ValidateString(user.FirstName) == null
                || ValidationHelper.ValidateString(user.LastName) == null
                || ValidationHelper.ValidateUsername(user.Username) == null
                || ValidationHelper.ValidatePassword(user.Password) == null)
            {
                MessageHelper.Color("[Error] Invalid Info!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }
            int id = _db.Insert(user);
            return _db.GetById(id);
        }

        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            T user = _db.GetById(userId);
            if (ValidationHelper.ValidateString(firstName) == null || ValidationHelper.ValidateString(lastName) == null)
            {
                MessageHelper.Color("[Error] strings were not valid. Please try again!", ConsoleColor.Red);
                Console.ReadLine();
                return;
            }
            user.FirstName = firstName;
            user.LastName = lastName;
            _db.Update(user);
            MessageHelper.Color("Data successfuly changed!", ConsoleColor.Green);
            Console.ReadLine();
        }
    }
}
