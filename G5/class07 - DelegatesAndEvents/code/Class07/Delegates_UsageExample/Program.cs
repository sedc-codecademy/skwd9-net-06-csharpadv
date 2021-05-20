using System;
using System.Collections.Generic;

namespace Delegates_UsageExample
{
    public delegate bool IsPromotable(Employee emplyee);

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeDb = new List<Employee>();

            employeeDb.Add(new Employee() { Id = 101, Name = "Bob", Experience = 4, Salary = 6000 });
            employeeDb.Add(new Employee() { Id = 102, Name = "Jill", Experience = 7, Salary = 12000 });
            employeeDb.Add(new Employee() { Id = 103, Name = "Greg", Experience = 2, Salary = 1500 });
            employeeDb.Add(new Employee() { Id = 104, Name = "Mark", Experience = 8, Salary = 10000 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployees(employeeDb, isPromotable);

            Employee.PromoteEmployees(employeeDb, emp => emp.Experience > 5);

            //Employee.PromoteEmployees(employeeDb);

            Console.ReadLine();
        }

        public static bool Promote(Employee emp) 
        {
            return emp.Salary > 7000;
        }
    }

    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployees(List<Employee> employeeList, IsPromotable isPromotable)
        {
            foreach (var employee in employeeList)
            {
                if (isPromotable(employee))
                {
                    Console.WriteLine($"{employee.Name} has been promoted!");
                }
            }
        }


        //public static void PromoteEmployees(List<Employee> employeeList) 
        //{
        //    foreach (var employee in employeeList)
        //    {
        //        if (employee.Experience > 5) 
        //        {
        //            Console.WriteLine($"{employee.Name} has been promoted!");
        //        }
        //    }
        //}
    }
}
