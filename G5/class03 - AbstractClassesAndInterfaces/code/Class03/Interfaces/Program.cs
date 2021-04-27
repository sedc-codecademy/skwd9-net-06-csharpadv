using Interfaces.Models.Interfaces;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can't create an instance of an Interface
            //IUser user = new IUser();

            var AppSerice = new AppService();
            AppSerice.RunApp();

            Console.ReadLine();
        }
    }
}
