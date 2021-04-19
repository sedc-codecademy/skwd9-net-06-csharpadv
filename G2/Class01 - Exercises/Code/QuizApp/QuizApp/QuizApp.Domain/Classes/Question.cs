using System.Collections.Generic;

namespace QuizApp.Domain.Classes
{
    public class Question
    {
        public string Description { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
