using QuizApp.Domain.Classes;
using QuizApp.Services;
using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            QuizService quizService = new QuizService();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    if(string.IsNullOrEmpty(username))
                    {
                        throw new Exception("You must enter username");
                    }

                    Teacher teacher = userService.GetTeacherByUserName(username);
                    if(teacher != null)
                    {
                        bool passwordsMatch = userService.PasswordsMatch(teacher.Password);
                        if (!passwordsMatch)
                        {
                            throw new Exception("Password did not match 3 times. try again after 30 minutes");
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach(Student student in userService.GetStudentsThatDidTheQuiz())
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName} {student.CorrectAnswers}");
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        foreach (Student student in userService.GetStudentsThatDidNotFinishTheQuiz())
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName}");
                        }

                        Console.ResetColor();
                    }
                    else
                    {
                        Student student = userService.GetStudentByUserName(username);
                        if(student == null)
                        {
                            throw new Exception("The user does not exist");
                        }
                        bool passwordsMatch = userService.PasswordsMatch(student.Password);
                        if (!passwordsMatch)
                        {
                            throw new Exception("Password did not match 3 times. Try again after 30 minutes");
                        }
                        if (student.HasFinishedQuiz)
                        {
                            throw new Exception("You already did the quiz");
                        }
                        quizService.TakeQuiz(student);
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine("An error occured");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
