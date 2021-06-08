using System.Collections.Generic;
using MapperDemo.DomainModels;

namespace MapperDemo.DataLayer
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudent();
    }
}
