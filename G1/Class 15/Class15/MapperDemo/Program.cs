using System;
using System.Collections.Generic;
using MapperDemo.BusinessLayer;
using MapperDemo.ViewModels;

namespace MapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //IStudentService studentService = new StudentService();

            //List<StudentModel> students = studentService.GetAllStudents(new Pagination()
            //{
            //    Page = 3,
            //    ItemsPerPage = 2
            //});

            //foreach (StudentModel student in students)
            //{
            //    Console.WriteLine($"{student.FullName, 40}|{student.Age}");
            //}

            AcademyModel academy = new AcademyModel()
            {
                Name = "SEDC",
                Address = "Kisela Voda"
            };

            AcademyModel emptyAcademy = new AcademyModel();

            GeneralMapper.GeneralMapper.MapObjects(academy, emptyAcademy);

            SubjectModel subject = new SubjectModel()
            {
                Name = "C# advance",
                NumberOfClasses = 40
            };

            SubjectModel emptySubject = new SubjectModel();

            GeneralMapper.GeneralMapper.MapObjects(subject, emptySubject);

            SubjectModel test = new SubjectModel();
            GeneralMapper.GeneralMapper.MapObjects(academy, test);
        }
    }
}
