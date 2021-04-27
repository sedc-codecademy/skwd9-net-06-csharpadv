using SEDC.Class03.EmployeeManagementApp.Domain.Enums;
using System;

namespace SEDC.Class03.EmployeeManagementApp.Domain.Models
{
    public class PartTimeEmployee : BaseEmployee
    {
        public PartTimeEmployee(string firstName, string lastName, string phoneNumber, string address, string employer, JobPosition jobPosition, int contractDuration, int hoursWorkedMonthly) 
            : base(firstName, lastName,phoneNumber,address,employer,jobPosition, hoursWorkedMonthly)
        {
            this.ContractDuration = contractDuration;
            this.TotalPayment = hoursWorkedMonthly * this.HourlyWage;
            if (hoursWorkedMonthly > 80)
            {
                this.OvertimePay = (decimal)(hoursWorkedMonthly - 80) * (this.HourlyWage * 1.5m);
                this.TotalPayment = this.OvertimePay + (80 * HourlyWage);
            }
        }

        public int ContractDuration { get; set; }
        public decimal HourlyWage { get; set; } = 9.25m;
        public decimal OvertimePay { get; set; }
        public decimal TotalPayment { get; set; }

        public override void PrintEmployeeInfo()
        {
            System.Console.WriteLine($"{GetEmployeeFullName()} works at {this.Employer} and his monthly salary is {this.TotalPayment}$");
        }
    }
}
