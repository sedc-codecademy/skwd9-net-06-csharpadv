using System.Collections.Generic;

namespace MapperDemo.ViewModels
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }
        public List<SubjectModel> Subjects { get; set; }
        public int NumberOfSubjects => Subjects.Count;

        public StudentModel()
        {
            Subjects = new List<SubjectModel>();
        }
    }
}
