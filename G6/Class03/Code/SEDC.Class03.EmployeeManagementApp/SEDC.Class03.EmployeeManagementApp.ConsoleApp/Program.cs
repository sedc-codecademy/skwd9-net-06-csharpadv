using System;
using SEDC.Class03.EmployeeManagementApp.Domain.Models;
using SEDC.Class03.EmployeeManagementApp.Domain.Enums;

namespace SEDC.Class03.EmployeeManagementApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will not compile. We can not create objects from abstract class
            //BaseEmployee regularEmployee = new BaseEmployee();
            FullTimeEmployee damjan =
                new FullTimeEmployee("Damjan", "Stojanovski", "075 000 000", "Georgi Dimitrov bb", "Haselt", JobPosition.Developer, 8000.50m, 160);
            PartTimeEmployee bob = new PartTimeEmployee("Bob", "Bobsky", "075 111 111", "Adress 1", "EXC Solutions", JobPosition.Devops, 6, 81);
            bob.PrintEmployeeInfo();
            damjan.PrintEmployeeInfo();
            Console.ReadLine();
        }
    }
}
