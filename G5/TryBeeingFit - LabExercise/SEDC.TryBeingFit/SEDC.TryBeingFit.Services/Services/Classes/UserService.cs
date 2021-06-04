using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SEDC.TryBeingFit.Domain.Core.Entities.User;
using SEDC.TryBeingFit.Domain.Core.Enum;
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
            //Database = new LocalDb<T>();
            Database = new FileSystemDb<T>();
        }

        public T Login(string username, string password)
        {
            List<T> users = Database.GetAll();
            T user = users.SingleOrDefault(user => user.Username == username && user.Password == password);

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
            if (ValidationHelper.ValidateString(user.FirstName) == null
                || ValidationHelper.ValidateString(user.LastName) == null
                || ValidationHelper.ValidateUsername(user.Username) == null
                || ValidationHelper.ValidatePassword(user.Password) == null) 
            {
                MessageHelper.Color("[Error] Invalid info!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }

            int id = Database.Insert(user);
            return Database.GetById(id);
        }

        public void ChangePassword(int id, string oldPassword, string newPassword)
        {
            T user = Database.GetById(id);

            if (newPassword == oldPassword) 
            {
                MessageHelper.Color("[Error] You can not use the same password!", ConsoleColor.Red);
                Console.ReadLine();
                return;
            }

            if (ValidationHelper.ValidatePassword(newPassword) == null) 
            {
                MessageHelper.Color("[Error] New password is not valid!", ConsoleColor.Red);
                Console.ReadLine();
                return;
            }

            user.Password = newPassword;
            Database.Update(user);

            MessageHelper.Color("Password successfully changed!", ConsoleColor.Green);
            Console.ReadLine();
        }

        public void ChangeInfo(int id, string firstName, string lastName)
        {
            T user = Database.GetById(id);

            if (ValidationHelper.ValidateString(firstName) == null || ValidationHelper.ValidateString(lastName) == null) 
            {
                MessageHelper.Color("[Error] Strings are not valid", ConsoleColor.Red);
                Console.ReadLine();
                return;
            }

            user.FirstName = firstName;
            user.LastName = lastName;
            Database.Update(user);

            MessageHelper.Color("Data successfully changed!", ConsoleColor.Green);
            Console.ReadLine();
        }

        public T GetById(int id)
        {
            return Database.GetById(id);
        }

        public void DeleteById(int id) 
        {
            Database.RemoveById(id);
        }

        public PremiumUser MapToPremiumUser(User user)
        {
            return new PremiumUser()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                Role = UserRole.Premium,
            };
        }

        public bool IsDbEmpty()
        {
            return Database.GetAll() == null;
        }

    }
}
