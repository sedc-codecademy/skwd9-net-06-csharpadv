using System;
using OrderingSystem_Models.Db;
using OrderingSystem_Models;

namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                try
                {
                    Console.WriteLine("Enter username to login");
                    Console.WriteLine(Storage.ListAllUsers());

                    string username = Console.ReadLine();
                    User loginUser = Storage.GetUserByUsername(username);

                    Console.WriteLine("Orders:");
                    foreach(Order o in loginUser.Orders)
                    {
                        Console.WriteLine(o.Name);
                    }

                    Console.WriteLine("If you want to enter new user please enter y");
                    if(Console.ReadLine() == "y")
                    {
                        Console.WriteLine("Please enter username");
                        string newUsername = Console.ReadLine();

                        Storage.AddUser(newUsername);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
