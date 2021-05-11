using AdvancedLINQ.Domain;
using AdvancedLINQ.Domain.Enums;
using AdvancedLINQ.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHERE
            List<Student> studentsNamedBob = SEDC.Students.Where(x => x.FirstName == "Bob").ToList();
            studentsNamedBob.PrintEntities();

            IEnumerable<Student> studentsNamedBobSql = from x in SEDC.Students
                                                       where x.FirstName == "Bob"
                                                       select x;
            studentsNamedBobSql.ToList().PrintEntities();

            //SELECT
            List<string> fullNames = SEDC.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
            fullNames.Print();

            List<string> fullNamesSql = (from x in SEDC.Students
                                         select $"{x.FirstName} {x.LastName}").ToList();
            fullNamesSql.Print();

            //COMPLEX EXAMPLE
            List<Student> students = (from x in SEDC.Students
                                      where x.IsPartTime
                                      where (
                                         from y in x.Subjects
                                         where y.Academy == AcademyType.WebProgramming
                                         select y).ToList().Count != 0
                                      select x).ToList();

            List<Student> programmingStudents = SEDC.Students.Where(x => x.IsPartTime)
                                                .Where(x => 
                                                x.Subjects.Where(y => y.Academy == AcademyType.WebProgramming)
                                                .ToList().Count != 0)
                                                .ToList();
            students.PrintEntities();
            programmingStudents.PrintEntities();


            // FIRST / SINGLE / LAST / ORDEFAULT
            // First => Gets first element, if no elements it will throw error
            // FirstOrDefault => Gets first element, if no elements will return default and will not throw error
            // Last => Gets last element, if no elements it will throw error
            // LastOrDefault => Gets last element, if no elements will return default and will not throw error
            // Single => Gets the only element from list, if more than one elements or no elements will throw error
            // SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error
            Console.WriteLine(SEDC.Students.First().GetInfo());
            //Console.WriteLine(SEDC.Students.First(x => x.Age == 18).GetInfo()); - ERROR
            Console.WriteLine(SEDC.Students.FirstOrDefault(x => x.Age == 18)?.GetInfo());

            //Student ageAbove30 = SEDC.Students.Single(x => x.Age > 30); ERROR - more than element with this condition

            // Issue because it does not give all the results in one list, but creates a list of lists
            List<List<Subject>> subjects = SEDC.Students.Where(x => x.IsPartTime).Select(x => x.Subjects).ToList();

            //SELECT MANY
            // It flatens list of lists
            // Flattening => When we make one list out of multiple lists of the same type
            List<Subject> partTimeSubjects = SEDC.Students.Where(x => x.IsPartTime).SelectMany(x => x.Subjects).ToList();
            Console.WriteLine(partTimeSubjects[0].GetInfo());

            //ANY
            bool isThereAnyBob = SEDC.Students.Any(x => x.FirstName == "Bob");
            Console.WriteLine(isThereAnyBob);

            //ALL
            bool ageAbove18 = SEDC.Students.All(x => x.Age > 18);
            bool ageAbove30 = SEDC.Students.All(x => x.Age > 30);

            //DISTINCT
            List<Subject> distinctSubjects = SEDC.Subjects.Distinct().ToList();
            distinctSubjects.PrintEntities();

            //EXCEPT
            List<Student> exceptPartTime = SEDC.Students.Except(SEDC.Students.Where(x => x.IsPartTime)).ToList();

            //ORDER By
            List<Student> orderedByAge = SEDC.Students.OrderBy(x => x.Age).ToList();
            orderedByAge.PrintEntities();
            List<Student> orderedStudents = SEDC.Students.OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList();
            Console.ReadLine();
        }
    }
}
