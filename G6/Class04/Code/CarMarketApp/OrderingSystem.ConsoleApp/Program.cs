using OrderingApp.Models;
using OrderingApp.Models.Db;
using System;

namespace OrderingSystem.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a username");
                MockUpDatabase.PrintAllUsers();
                string usernameInput = Console.ReadLine();
                User loggedinUser = MockUpDatabase.GetUserByName(usernameInput);
                Console.WriteLine("The user with " + loggedinUser.Name + "is logged in");
                Console.WriteLine("Do you want to add an other user");
                if(Console.ReadLine() == "y")
                {
                    Console.WriteLine("Please provide a username to the new user");
                    string newUsername = Console.ReadLine();
                    int isUserAdded = MockUpDatabase.AddUserToDb(newUsername);
                    if(isUserAdded == 1)
                    {
                        Console.WriteLine("You have succedully added a user");
                    }
                    else
                    {
                        Console.WriteLine("There was something wrong");
                        break;
                    }
                }
            }
        }
    }
}
