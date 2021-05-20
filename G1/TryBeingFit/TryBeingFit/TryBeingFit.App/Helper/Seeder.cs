using System;
using TryBeingFit.Domain.Database;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.App.Helper
{
    public static class Seeder
    {
        public static void Seed()
        {
            Console.WriteLine("Seeding data.....");
            LocalDatabase.StandardUsers.Insert(new StandardUser("Risto", "Panchevski", "ristop", "risto123"));
            LocalDatabase.PremiumUsers.Insert(new PremiumUser("Radmila", "Kocovska", "radmila", "radmila123"));
            LocalDatabase.TrainerUsers.Insert(new TrainerUser("Mile", "Atleta", "mile_atleta", "atleta123"));

            Console.WriteLine("Complete seeding data.....");
        }
    }
}
