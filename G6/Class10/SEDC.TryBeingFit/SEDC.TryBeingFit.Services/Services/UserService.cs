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
            throw new NotImplementedException();
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
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
            throw new NotImplementedException();
        }
    }
}
