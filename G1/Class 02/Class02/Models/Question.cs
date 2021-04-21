using System.Collections.Generic;

namespace Models
{
    public class Question
    {
        public string QuestionString { get; set; }
        //public List<string> Answers { get; set; }
        //public string Question1 { get; set; }
        //public string Question2 { get; set; }
        //public string Question3 { get; set; }
        //public string Question4 { get; set; }
        //pubic string CorrectAnswer { get; set; }
        //Dodoma false
        //Hobart true
        //Launceston false
        //Wellington false
        public Dictionary<string, bool> Answers { get; set; }

        public Question(string questionString, Dictionary<string, bool> answers)
        {
            QuestionString = questionString;
            Answers = answers;
        }

        public string GetQuestionFormatted()
        {
            string question = $"{QuestionString}\n";

            int questionNumber = 1;
            foreach (KeyValuePair<string, bool> answer in Answers)
            {
                question += $"\t{questionNumber}. {answer.Key}\n";
                questionNumber++;
            }

            return question;
        }
        
        public bool CorrectlyAnswered(string answer)
        {
            return Answers[answer];
        }
    }
}
