using SEDC.Class03.EmployeeManagementApp.Domain.Enums;
using System;

namespace SEDC.Class03.EmployeeManagementApp.Domain.Models
{
    public abstract class BaseEmployee
    {
        //Abstract class can have constructors
        public BaseEmployee(string firstName, string lastName, string phoneNumber, string address, string employeer, JobPosition jobPosition, int hoursWorked)
        {
            this.ID = new Random().Next(1, 10000);
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Employer = employeer;
            this.JobPosition = jobPosition;
            this.HoursWorkedMonthly = hoursWorked;
        }
        private int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Employer { get; set; }
        public JobPosition JobPosition { get; set; }
        public int HoursWorkedMonthly { get; set; }

        //In abstract class we can have regular methods as well.
        public string GetEmployeeFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
        //We can have abstract methods only in abstract classes.
        //Abstract methods do not have implementation just method signiture.
        //We must implement the abstract methods in the derived classes. App will not complile otherwise.
        public abstract void PrintEmployeeInfo();
    }
}
