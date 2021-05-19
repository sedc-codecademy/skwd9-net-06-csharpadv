using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.User;
using SEDC.TryBeingFit.Domain.Db.Classes;
using SEDC.TryBeingFit.Domain.Db.Interfaces;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Services.Interfaces;

namespace SEDC.TryBeingFit.Services.Services.Classes
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDb<T> Database { get; set; }

        public UserService()
        {
            Database = new LocalDb<T>();
        }

        public T Login(string username, string password)
        {
            T user = Database.GetAll().SingleOrDefault(user => user.Username == username && user.Password == password);

            if (user == null) 
            {
                MessageHelper.Color("[Error] Username or Password did not match!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }

            return user;
        }

        public T Register(T user)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(int id, int oldPassword, int newPassword)
        {
            throw new NotImplementedException();
        }

        public void ChangeInfo(int id, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public bool IsDbEmpty()
        {
            return Database.GetAll() == null;
        }

    }
}
