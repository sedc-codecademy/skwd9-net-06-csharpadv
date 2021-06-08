using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapperDemo.DataLayer;
using MapperDemo.DomainModels;
using MapperDemo.Mappers;
using MapperDemo.ViewModels;

namespace MapperDemo.BusinessLayer
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        //1,2,3,4,5,6,7
        public List<StudentModel> GetAllStudents(Pagination pagination)
        {
            //List<Student> students = _studentRepository.GetAllStudent();
            //List<Student> studentsPerRequiredPage = students.Skip(pagination.Page - 1 * pagination.ItemsPerPage)
            //    .Take(pagination.ItemsPerPage).ToList();

            List<Student> students = _studentRepository.GetAllStudent()
                .Skip((pagination.Page - 1) * pagination.ItemsPerPage)
                .Take(pagination.ItemsPerPage).ToList();

            //return students.Select(x => new StudentModel
            //{
            //    FirstName = x.FirstName,
            //    LastName = x.LastName,
            //    Age = x.Age,
            //    Subjects = x.Subjects.Select(y => new SubjectModel
            //    {
            //        Name = y.Name,
            //        NumberOfClasses = y.NumberOfClasses
            //    }).ToList()
            //}).ToList();

            //return students.Select(x => x.ToModel()).ToList();

            return students.Select(x => 
                    (StudentModel) GeneralMapper.GeneralMapper.MapObjects(x, new StudentModel()))
                .ToList();
        }
    }
}
