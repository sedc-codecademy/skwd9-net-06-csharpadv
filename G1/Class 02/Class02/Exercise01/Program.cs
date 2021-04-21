using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new Teacher("Risto", "Panchevski", "risto", "test123"),
                new Teacher("Radmila", "Kocovska", "radmila", "test111"),
                new Student("Aleksandar", "Panovski", "aleksandar", "test222"),
                new Student("Aleksandar", "Planic", "aleksandar_p", "test333"),
                new Student("Andrej", "Ivanov", "andrej", "test444")
            };

            List<Question> questions = new List<Question>()
            {
                new Question("What is the capital of Tasmania?", new Dictionary<string, bool>
                {
                    {"Dodoma", false},
                    {"Hobart", true},
                    {"Launceston", false},
                    {"Wellington", false}
                }),
                new Question("What is the tallest building in the Republic of the Congo?", new Dictionary<string, bool>
                {
                    {"Kinshasa Democratic Republic of the Congo Temple", false},
                    {"Palais de la Nation", false},
                    {"Kongo Trade Centre", false},
                    {"Nabemba Tower", true}
                }),
                new Question("Which of these is not one of Pluto's moons?", new Dictionary<string, bool>
                {
                    {"Styx", false},
                    {"Hydra", false},
                    {"Nix", true},
                    {"Lugia", false}
                }),
                new Question("What is the smallest lake in the world?", new Dictionary<string, bool>
                {
                    {"Onega Lake", false},
                    {"Benxi Lake", true},
                    {"Kivu Lake", false},
                    {"Wakatipu Lake", false}
                }),
                new Question("What country has the largest population of alpacas?", new Dictionary<string, bool>
                {
                    {"Chad", false},
                    {"Peru", true},
                    {"Australia", false},
                    {"Niger", false}
                }),
                new Question("What country has the largest area?", new Dictionary<string, bool>
                {
                    {"Macedonia", false},
                    {"Russia", true},
                    {"Serbia", false},
                    {"Croatia", false},
                    {"Greece", false}
                }),
            };

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Please enter password");
                    string password = Console.ReadLine();

                    //1
                    //User loginUser = Login(username, password, users);

                    //if (loginUser == null)
                    //{
                    //    throw new Exception("Invalid username or password");
                    //}

                    //2
                    //User loginUser = null;

                    //foreach (User user in users)
                    //{
                    //    loginUser = user.Login(username, password);

                    //    if (loginUser != null)
                    //    {
                    //        break;
                    //    }
                    //}

                    User loginUser = users.FirstOrDefault(x => x.Login(username, password) != null);

                    if (loginUser == null)
                    {
                        throw new Exception("Invalid username");
                    }

                    if (loginUser.Role == RoleEnum.Student)
                    {
                        StudentUI(questions, (Student)loginUser);
                    }
                    else if (loginUser.Role == RoleEnum.Teacher)
                    {
                        TeacherUI(users, (Teacher)loginUser);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //static User Login(string username, string password, List<User> users)
        //{
        //    //if (users.Any(x => x.UserName.ToLower() == username.ToLower() && x.Locked))
        //    //{
        //    //    throw new Exception("Account is locked");
        //    //}

        //    //User loginUser =
        //    //    users.FirstOrDefault(x =>
        //    //        x.UserName.ToLower() == username.ToLower() && !x.Locked && x.ValidPassword(password));

        //    User loginUser =
        //        users.FirstOrDefault(x =>
        //            x.UserName.ToLower() == username.ToLower() && x.ValidPassword(password));

        //    return loginUser;
        //}
        static void StudentUI(List<Question> questions, Student loginUser)
        {
            if (loginUser.QuizStatus == QuizStatus.Finished)
            {
                Console.WriteLine($"Hi {loginUser.FullName}! You have already completed the test");
                return;
            }

            //int score = 0;
            Console.WriteLine($"Hi {loginUser.FullName}!\nLet's start the quiz");

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Q: {questions[i].GetQuestionFormatted()}");
                Console.Write($"Please select an answer by typing number between 1-{questions[i].Answers.Count}: ");
                string choiceString = Console.ReadLine();

                bool choiceParse = int.TryParse(choiceString, out int choice);

                if (!choiceParse || choice < 1 || choice > questions[i].Answers.Count)
                {
                    //throw new Exception("You have entered wrong input, you are not serious bye!");
                    Console.WriteLine("Wrong input for choice. Please select valid choice.");
                    i--;
                    continue;
                }

                //1-4
                List<string> answers = questions[i].Answers.Select(x => x.Key).ToList();
                string selectedAnswer = answers[choice - 1];
                bool correctAnswer = questions[i].CorrectlyAnswered(selectedAnswer);

                if (correctAnswer)
                {
                    loginUser.QuizScore++;
                }
            }

            loginUser.QuizStatus = QuizStatus.Finished;

            Console.WriteLine($"{loginUser.FullName} your score is: {loginUser.QuizScore}");
        }

        static void TeacherUI(List<User> users, Teacher loginUser)
        {
            Console.WriteLine($"Hi {loginUser.FullName}. Here are the scores:");

            List<Student> students = users.Where(x => x.Role == RoleEnum.Student).Select(x => (Student) x).ToList();

            List<Student> studentsThatHaveFinishedTheTest =
                students.Where(x => x.QuizStatus == QuizStatus.Finished).ToList();

            List<Student> studentsThatHaveNotFinishedTheTest =
                students.Where(x => x.QuizStatus == QuizStatus.NotStarted).ToList();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"Name", 30} | {"Score", 5}");

            foreach (Student student in studentsThatHaveFinishedTheTest)
            {
                Console.WriteLine($"{student.FullName,30} | {student.QuizScore,5}");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"Name",30} | {"Score",5}");

            foreach (Student student in studentsThatHaveNotFinishedTheTest)
            {
                Console.WriteLine($"{student.FullName,30} | {"/",5}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
