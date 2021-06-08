using SEDC.Adv.Class02.Database.DB;
using SEDC.Adv.Class02.Database.Models;
using System;

namespace SEDC.Adv.Class02.Logic.Services
{
    public class QuizService
    {
        private InMemoryDatabase _inMemoryDatabase;

        public QuizService()
        {
            _inMemoryDatabase = new InMemoryDatabase();
        }

        public void TakeQuiz(User user)
        {
            var questions = _inMemoryDatabase.GetAllQuestions();

            foreach (var question in questions)
            {
                Console.WriteLine(question.Description);
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {question.Answers[i]}");
                }

                bool isAnswered = false;
                while (!isAnswered)
                {
                    bool isValidSelection = int.TryParse(Console.ReadLine(), out int selection);

                    if (!isValidSelection)
                    {
                        Console.WriteLine("Enter valid answer");
                        continue;
                    }

                    if(selection < 1 || selection > 4)
                    {
                        Console.WriteLine("Not valid selection");
                        continue;
                    }

                    if(question.CorrectAnswer == selection - 1)
                    {
                        user.CorrectAnswers += 1;
                    }
                    isAnswered = !isAnswered;
                }
            }
            user.HasFinishedTest = true;
            Console.WriteLine("Thank you for finishing quiz");
        }
    }
}
