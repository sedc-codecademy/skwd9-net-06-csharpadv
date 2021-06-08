using System;
using System.Collections.Generic;
using System.Text;
using MapperDemo.ViewModels;

namespace MapperDemo.BusinessLayer
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudents(Pagination pagination);
    }
}
