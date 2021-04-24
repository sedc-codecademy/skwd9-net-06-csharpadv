using Models;
using Models.UserFolder;
using QuizApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    class Program
    {
        private static User _loggedUser = null;
        private static Student _student = null;
        private static Teacher _teacher = null;
        private static Data _data = new Data();
        private static QuizUsers _quizUsers = new QuizUsers();
        static void Main(string[] args)
        {
            int logingAttempc = 0;
            while (true)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                _loggedUser = _quizUsers.AllUsers
                                                .Where(x => x.Username == username)
                                                .Where(y => y.PassCheck(password) == true)
                                                .FirstOrDefault();
                //.FirstOrDefault(y => y.PassCheck(password) == true);

                if(_loggedUser == null)
                {
                    logingAttempc++;
                    Console.WriteLine("Wrong username or password");
                    if(logingAttempc == 3)
                    {
                        Console.WriteLine("You tried three times to log in");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    logingAttempc = 0;
                    Console.WriteLine("You are logged in");
                }

                // Studen______________________________________________________________________

                if(_loggedUser.Role == Role.Student)
                {
                    _student = (Student)_loggedUser;

                    if (_student.DoneTest)
                    {
                        Console.WriteLine("You have already completed the test");
                        continue;
                    }

                    int correctAnswer = 0;
                    foreach(Question question in _data.AllQuestions)
                    {
                        Console.WriteLine(question.Text);

                        int counter = 0;
                        foreach(string answ in question.PossibleAnswer)
                        {
                            counter++;
                            Console.WriteLine($"{counter} : {answ}");
                        }

                        while (true)
                        {
                            bool parseSuc = int.TryParse(Console.ReadLine(), out int input);
                            if(input < 1 || input > 4 || !parseSuc)
                            {
                                Console.WriteLine("Invalid input");
                                continue;
                            }
                            if(question.CorrectAnswer == input)
                            {
                                correctAnswer++;
                                Console.WriteLine("Correct");
                                break;
                            }
                            if(question.CorrectAnswer != input)
                            {
                                Console.WriteLine("The answer is incorrect");
                                break;
                            }
                        }


                    }

                    _student.Grade = correctAnswer;
                    _student.DoneTest = true;

                    Console.WriteLine("You have completed the quiz with a grade of {0}", _student.Grade);

                }

                // Teacher__________________________________________________
                if(_loggedUser.Role == Role.Teacher)
                {
                    List<Student> studentsDone = _quizUsers.AllUsers
                                                        .Where(x => x.Role == Role.Student)
                                                        .Select(y => (Student)y)
                                                        .Where(d => d.DoneTest == true)
                                                        .ToList();

                    Console.ForegroundColor = ConsoleColor.Green;
                    if(studentsDone.Count == 0)
                    {
                        Console.WriteLine("No one has completed the quiz");
                    }

                    studentsDone.ForEach(d => Console.WriteLine("{0} : {1}", d.Username, d.Grade));

                    List<Student> studentsDidNotDo = _quizUsers.AllUsers
                                                      .Where(x => x.Role == Role.Student)
                                                      .Select(y => (Student)y)
                                                      .Where(d => d.DoneTest == false)
                                                      .ToList();
                    Console.ForegroundColor = ConsoleColor.Red;
                    if(studentsDidNotDo.Count == 0)
                    {
                        Console.WriteLine("All students completed the quiz");
                    }

                    studentsDidNotDo.ForEach(d => Console.WriteLine($"{d.Username}"));

                    Console.ResetColor();
                    Console.ReadLine();


                }

            }
        }
    }
}
