using SEDC.Adv.Class02.Database.DB;
using SEDC.Adv.Class02.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.Adv.Class02.Logic.Services
{
    public class UserService
    {
        private InMemoryDatabase _inMemoryDatabase;

        public UserService()
        {
            _inMemoryDatabase = new InMemoryDatabase();
        }

        public User Login()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            var user = _inMemoryDatabase.GetUserByUserName(username);

            if(user == null)
            {
                Console.WriteLine("Username does not exists.");
                return null;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if(user.Password == password)
                {
                    return user;
                }
            }

            Console.WriteLine("You missed password 3 times. Try again in 30 min");
            Thread.Sleep(3000);
            Environment.Exit(1);
            return null;
        }

        public List<User> GetStudents()
        {
            return _inMemoryDatabase.GetStudents();
        }
    }
}
