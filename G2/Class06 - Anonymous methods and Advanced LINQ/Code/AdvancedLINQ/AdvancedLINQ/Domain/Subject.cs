using AdvancedLINQ.Domain.Enums;

namespace AdvancedLINQ.Domain
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public int NumOfModules { get; set; }
        public int StudentsAttending { get; set; }
        public AcademyType Academy { get; set; }
        public Subject(int id, string title, int numOfModules, int numOfStudents, AcademyType academy)
        {
            Id = id;
            Title = title;
            NumOfModules = numOfModules;
            StudentsAttending = numOfStudents;
            Academy = academy;
        }
        public override string GetInfo()
        {
            return $"[{Id}] - Academy: {Academy}, Title: {Title}, number of students: {StudentsAttending}";

        }
    }
}
