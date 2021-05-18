using Logger.Domain;
using Logger.Exceptions;
using Logger.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logger
{
    class Program
    {
        static LoggerService loggerService = new LoggerService();
        static List<User> Users = new List<User>()
        {
            new User(){Username = "Bob20", Password = "123456", Age = 20, Id = 4 },
            new User(){Username = "JillCool", Password = "coolcat", Age = 34, Id = 12 },
            new User(){Username = "Gregonator", Password = "astalavista", Age = 44, Id = 76 }
        };

        public static void Login(string username, string password)
        {
            User user = Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if(user == null)
            {
                throw new InvalidLoginException(username);
            }
            Console.WriteLine($"Welcome {username}");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Users.Count);
            //Console.WriteLine(Users.First().Age) ;

            try
            {
                //Login("paul", "paul123"); //InvalidLoginException
                User newUser = new User { Id = 7, Username = "paulp", Password = "paul123", Age = -3 }; //InvalidPropertyException
                int num = int.Parse("test");
            }
            catch(InvalidLoginException e)
            {
                Console.WriteLine("Check your username and password");
                loggerService.Log("InvalidLogin", e.Message);
            }
            catch (InvalidPropertyException e)
            {
                Console.WriteLine("Check your age");
                loggerService.Log("InvalidProperty", e.Message);
            }
            catch(Exception e)
            {
                loggerService.Log("Exception", e.Message);
                loggerService.LogErrorCount();
            }
            Console.ReadLine();
        }
    }
}
