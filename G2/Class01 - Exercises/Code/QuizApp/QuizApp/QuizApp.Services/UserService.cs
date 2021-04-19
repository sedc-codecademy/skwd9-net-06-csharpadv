using QuizApp.Domain;
using QuizApp.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp.Services
{
    public class UserService
    {
        public Student GetStudentByUserName(string username)
        {
            return InMemoryDb.Students.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public Teacher GetTeacherByUserName(string username)
        {
            return InMemoryDb.Teachers.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public List<Student> GetStudentsThatDidTheQuiz()
        {
            return InMemoryDb.Students.Where(x=>x.HasFinishedQuiz).ToList();
        }

        public List<Student> GetStudentsThatDidNotFinishTheQuiz()
        {
            return InMemoryDb.Students.Where(x => !x.HasFinishedQuiz).ToList();
        }

        public bool PasswordsMatch(string password)
        {
            for(int i =0;i<3; i++)
            {
                Console.WriteLine("Enter password");
                string passwordInput = Console.ReadLine();
                if(password == passwordInput)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
