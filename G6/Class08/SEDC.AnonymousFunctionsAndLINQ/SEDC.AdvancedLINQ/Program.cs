using SEDC.AdvancedLINQ.Helpers;
using SEDC.AdvancedLINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.AdvancedLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ VS LINQ to SQL

            Console.WriteLine("WHERE()");
            IEnumerable<Student> bobStudentLambda = SEDC.Students.Where(x => x.FirstName == "Bob");

            IEnumerable<Student> bobStudentSql = from x in SEDC.Students
                                                 where x.FirstName == "Bob"
                                                 select x;

            bobStudentLambda.ToList().PrintEntities();
            bobStudentSql.ToList().PrintEntities();


            Console.WriteLine("SELECT()");
            //Simple select statement for selecting only the first names from the students list
            List<string> firstNamesLambda = SEDC.Students.Select(x => x.FirstName).ToList();

            List<string> firstNamesSql = (from x in SEDC.Students
                                          select x.FirstName).ToList();

            List<string> studentFullNamesLambda = SEDC.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
            List<string> studentFullNamesSql = (from x in SEDC.Students
                                                select $"{x.FirstName} {x.LastName}").ToList();
            firstNamesLambda.PrintSimple();
            firstNamesSql.PrintSimple();

            studentFullNamesLambda.PrintSimple();
            studentFullNamesSql.PrintSimple();



            List<Student> programmingPartTimeStudentsLambda = SEDC.Students
                                                                  .Where(student => student.IsPartTime)
                                                                  .Where(student => student.Subjects
                                                                         .Where(sub => sub.Type == Academy.Programming).Count() != 0)
                                                                  .ToList();

            List<Student> programmingPartTimeStudentsSql = (from student in SEDC.Students
                                                            where student.IsPartTime
                                                            where (from sub in student.Subjects
                                                                   where sub.Type == Academy.Programming
                                                                   select sub).ToList().Count != 0
                                                            select student).ToList();

            programmingPartTimeStudentsLambda.PrintEntities();
            programmingPartTimeStudentsSql.PrintEntities();



            // FIRST / SINGLE / LAST / ORDEFAULT
            // First => Gets first element, if no elements it will throw error
            // FirstOrDefault => Gets first element, if no elements will return default and will not throw error
            // Last => Gets last element, if no elements it will throw error
            // LastOrDefault => Gets last element, if no elements will return default and will not throw error
            // Single => Gets the only element from list, if more than one elements or no elements will throw error
            // SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error




            //SELECT MANY
            // It flatens list of lists

            List<List<Subject>> partTimeSubjectsSelect = SEDC.Students
                                                                    .Where(st => st.IsPartTime)
                                                                    .Select(st => st.Subjects)
                                                                    .ToList();


            List<Subject> partTimeSubjectMany = SEDC.Students
                                                    .Where(st => st.IsPartTime)
                                                    .SelectMany(st => st.Subjects).ToList();

            partTimeSubjectsSelect.ForEach(item => item.PrintEntities());
            partTimeSubjectMany.PrintEntities();


            //DISTINCT
            List<Subject> distinctSubjects = partTimeSubjectMany.Distinct().ToList();
            distinctSubjects.PrintEntities();

            //EXCEPT
            List<Student> exceptPartTime = SEDC.Students.Except(SEDC.Students.Where(stu => stu.IsPartTime)).ToList();
            exceptPartTime.PrintEntities();


            #endregion


            Console.ReadLine();
        }
    }
}
