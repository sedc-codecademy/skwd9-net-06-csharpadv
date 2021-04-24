using AtmExercise.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmExercise.InMemoryDatabase
{
    public static class ATM_DB
    {
        public static List<Customer> Users { get; set; } = GenerateCustomers();
        public static List<Admin> Admins { get; set; } = GenerateAdmins();

        public static List<Customer> GenerateCustomers()
        {
            return new List<Customer>()
            {
                new Customer("Bob", "Bobsky", 1234123412341234, 1234, 750),
                new Customer("Jill","Wayne", 8235823582358235, 9000, 1200),
                new Customer("Rayan","Dawn", 0090119122923393, 2500, 500),
                new Customer("Anne","May", 0000220311012203, 0000, 400)
            };
        }

        public static List<Admin> GenerateAdmins()
        {
            return new List<Admin>()
            {
                new Admin("Viktor", "Jakovlev", "vjakovlev", "123"),
                new Admin("Angela", "Kostadinova", "akostadinova", "123"),
            };
        }
    }


}
