namespace Models
{
    public class Student : User
    {
        public int QuizScore { get; set; }
        public QuizStatus QuizStatus { get; set; }

        public Student(string firstName, string lastName, string userName, string password) :
            base(firstName, lastName, userName, password, RoleEnum.Student)
        {
            QuizScore = 0;
            QuizStatus = QuizStatus.NotStarted;
        }
    }
}
