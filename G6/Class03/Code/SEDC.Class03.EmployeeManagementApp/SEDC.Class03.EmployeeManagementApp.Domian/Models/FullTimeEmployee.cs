using SEDC.Class03.EmployeeManagementApp.Domain.Enums;
using System;

namespace SEDC.Class03.EmployeeManagementApp.Domain.Models
{
    public class FullTimeEmployee : BaseEmployee
    {
        public FullTimeEmployee(string firstName, string lastName, string phoneNumber, string address, string employer, JobPosition jobPosition, decimal annualSalary, int hoursWorkedMonthly) 
            : base(firstName,lastName, phoneNumber, address,employer,jobPosition,hoursWorkedMonthly)
        {
            this.AnnualSalary = annualSalary;
        }
        public decimal AnnualSalary { get; set; }

        public decimal GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }

        public override void PrintEmployeeInfo()
        {
            System.Console.WriteLine($"{GetEmployeeFullName()} works at {this.Employer} and his monthly salary is {GetMonthlySalary().ToString("N2")}$");
        }
    }
}
