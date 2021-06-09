using SEDC.Adv.Class02.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv.Class02.Database.DB
{
    public class InMemoryDatabase
    {
        private List<User> Users { get; set; }
        private List<Question> Questions { get; set; }

        public InMemoryDatabase()
        {
            Users = new List<User>
            {
                new User() { Username = "Trainer", Password = "123", FullName = "Trainer", IsTeacher = true },
                new User() { Username = "Assistant", Password = "123", FullName = "Assistant", IsTeacher = true },
                new User() { Username = "student1", Password = "123", FullName = "student1" },
                new User() { Username = "student2", Password = "123", FullName = "student2" },
                new User() { Username = "student3", Password = "123", FullName = "student3" },
                new User() { Username = "student4", Password = "123", FullName = "student4" },
                new User() { Username = "student5", Password = "123", FullName = "student5" },
                new User() { Username = "student6", Password = "123", FullName = "student6" },
                new User() { Username = "student7", Password = "123", FullName = "student7" }
            };

            Questions = new List<Question>
            {
                new Question() 
                { 
                    Description = "What is the capital of Tasmania?",
                    Answers = new List<string>
                    {
                        "Dodoma",
                        "Hobart",
                        "Launceston",
                        "Wellington"
                    },
                    CorrectAnswer = 2
                },
                new Question() 
                { 
                    Description = "What is the tallest building in the Republic of the Congo?",
                    Answers = new List<string>
                    {
                        "Kinshasa Democratic Republic of the Congo Temple",
                        "Palais de la Nation",
                        "Kongo Trade Centre",
                        "Nabemba Tower"
                    },
                    CorrectAnswer = 4
                },
                new Question() 
                { 
                    Description = "Which of these is not one of Pluto's moons?",
                    Answers = new List<string>
                    {
                        "Styx",
                        "Hydra",
                        "Nix",
                        "Lugia"
                    },
                    CorrectAnswer = 4
                },
                new Question() 
                { 
                    Description = "What is the smallest lake in the world?",
                    Answers = new List<string>
                    {
                        "Onega Lake",
                        "Benxi Lake",
                        "Kivu Lake",
                        "Wakatipu Lake"
                    },
                    CorrectAnswer = 2
                },
                new Question()
                {
                    Description = "What country has the largest population of alpacas?",
                    Answers = new List<string>
                    {
                        "Chad",
                        "Peru",
                        "Australia",
                        "Niger"
                    },
                    CorrectAnswer = 2
                }
            };
        }

        public User GetUserByUserName(string username)
        {
            return Users.FirstOrDefault(_user => _user.Username.ToLower() == username.ToLower());
        }

        public List<User> GetStudents()
        {
            return Users.Where(_user => !_user.IsTeacher).ToList();
        }

        public List<User> GetUsersThatFinishedTest()
        {
            return Users.Where(_user => _user.HasFinishedTest).ToList();
        }

        public List<User> GetUsersThatNotFinishedTest()
        {
            return Users.Where(_user => !_user.HasFinishedTest).ToList();
        }

        public List<Question> GetAllQuestions()
        {
            return Questions;
        }
    }
}
