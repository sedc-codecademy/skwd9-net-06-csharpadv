using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Question
    {
        public string Text { get; set; }
        public string[] PossibleAnswer { get; set; }
        public int CorrectAnswer { get; set; }
        public Question() { }
        public Question(string text, string[] possibleAnswer, int correctAnswer)
        {
            Text = text;
            PossibleAnswer = possibleAnswer;
            CorrectAnswer = correctAnswer;
           
        }
    }
}
