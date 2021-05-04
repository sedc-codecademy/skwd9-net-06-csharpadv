using SEDC.CSharpAdv.VideoRental.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Data.Database
{
    public static class InMemoryDatabase
    {
        public static int userId = 1;
        public static List<User> Users { get; set; }

        static InMemoryDatabase()
        {
            InitDatabase();
        }

        private static void InitDatabase()
        {
            Users = new List<User>
            {
                new User() { Id = 1, CardNumber = 123, FullName = "Smiley Face" }
            };
        }
    }
}
