using AbstractClasses.Entities;
using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract classes and not be instantiated
            //User user = new User();

            Admin admin = new Admin();
            admin.SayHello("Viktor");
            admin.SayGoodbye("Viktor");


            Console.ReadLine();
        }

    }

}
