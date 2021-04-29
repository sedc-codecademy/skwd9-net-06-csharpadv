using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void PrintFullName() 
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        public string ReturnFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static void Greetings(User user) 
        {
            Console.WriteLine($"Hello, {user.ReturnFullName()}");
        }
    }
}
