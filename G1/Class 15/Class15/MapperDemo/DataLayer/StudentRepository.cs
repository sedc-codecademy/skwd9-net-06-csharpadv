using System.Collections.Generic;
using MapperDemo.Database;
using MapperDemo.DomainModels;

namespace MapperDemo.DataLayer
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAllStudent()
        {
            return Storage.Students;
        }
    }
}
