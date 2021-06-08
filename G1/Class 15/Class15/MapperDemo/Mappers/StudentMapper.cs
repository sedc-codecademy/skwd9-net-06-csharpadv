using System.Linq;
using MapperDemo.DomainModels;
using MapperDemo.ViewModels;

namespace MapperDemo.Mappers
{
    public static class StudentMapper
    {
        public static StudentModel ToModel(this Student student)
        {
            return new StudentModel
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age,
                Subjects = student.Subjects.Select(y => y.ToModel()).ToList()
            };
        }
    }
}
