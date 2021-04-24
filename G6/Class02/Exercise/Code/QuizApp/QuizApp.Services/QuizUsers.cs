using Models;
using Models.UserFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Services
{
    public class QuizUsers
    {
        public List<User> AllUsers { get; set; }
        public QuizUsers()
        {
            AllUsers = new List<User>
            {
                new Teacher("Damjan", "pass123"),
                new Student("Nikola", "nikola111"),
                new Student("Viktor", "vik123"),
                new Teacher("Petre","pass12"),
                new Student("Teodora", "teodora123"),
                new Student("Emilija", "emilija99")
            };
        }
    }
}
