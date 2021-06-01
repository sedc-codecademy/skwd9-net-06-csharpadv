using System;
using System.Collections.Generic;
using Domain;
using System.Linq;
using System.Net.Sockets;
using Domain.Entities;

namespace Linq_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ

            //WHERE
            //SQL Like Query
            IEnumerable<Student> findBobsSql = from x in SEDC.Students
                                               where x.FirstName == "Bob"
                                               select x;
            findBobsSql.ToList().PrintEntities();

            //Lambda
            IEnumerable<Student> findBobsLambda = SEDC.Students.Where(x => x.FirstName == "Bob");
            findBobsLambda.ToList().PrintEntities();

            //SELECT
            //SQL Like Query
            List<string> studentFullNamesSql = (from x in SEDC.Students
                                                select $"{x.FirstName} {x.LastName}").ToList();

            studentFullNamesSql.PrintSimple();

            //Lambda
            List<string> studentFullNamesLambda = SEDC.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
            studentFullNamesLambda.PrintSimple();

            //COMPLEX QUERY: All Students that are PartTime students and have at least one subject from Programming Academy
            //SQL Like Query

            List<Student> ptStudentsSql = (from x in SEDC.Students
                                           where x.IsPartTime &&
                                                 (from y in x.Subjects
                                                  where y.Type == Academy.Programming
                                                  select y).ToList().Count > 0
                                           select x).ToList();

            //List<Student> ptStudentsSql = (from x in SEDC.Students
            //                               where x.IsPartTime
            //                               where (from y in x.Subjects
            //                                      where y.Type == Academy.Programming
            //                                      select y).ToList().Count > 0
            //                               select x).ToList();

            ptStudentsSql.PrintEntities();

            //Lambda
            //List<Student> ptStudentsLambda = SEDC.Students.Where(x =>
            //    x.IsPartTime &&
            //    x.Subjects.Where(y => y.Type == Academy.Programming).ToList().Count > 0)
            //    .ToList();

            List<Student> ptStudentsLambda = SEDC.Students.Where(x =>
                                                                            x.IsPartTime &&
                                                                            x.Subjects.Any(y => y.Type == Academy.Programming))
                                                                            .ToList();

            ptStudentsLambda.PrintEntities();

            //Will throw exception if list is empty
            Student bobskyElement = SEDC.Students.First(x => x.LastName == "Bobsky");
            //Will return null if list is empty
            Student bobskyElement1 = SEDC.Students.FirstOrDefault(x => x.LastName == "Bobsky");
            //Will throw exception if list is empty
            Student bobskyElement2 = SEDC.Students.Last(x => x.LastName == "Bobsky");
            //Will return null if list is empty
            Student bobskyElement3 = SEDC.Students.LastOrDefault(x => x.LastName == "Bobsky");

            //SINGLE /ORDEFAULT
            //Student bobskyElement5 = SEDC.Students.SingleOrDefault(x => x.LastName == "Bobsky");
            Student bobskyElement4 = SEDC.Students.Single(x => x.Id == 55);
            Student bobskyElement5 = SEDC.Students.SingleOrDefault(x => x.Id == 55);

            //SELECTMANY
            List<List<Subject>> partTimeStudentSubjects = SEDC.Students.Where(x => x.IsPartTime).Select(x => x.Subjects).ToList();

            List<Subject> partTimeStudentSubjects1 = SEDC.Students.Where(x => x.IsPartTime).SelectMany(x => x.Subjects).ToList();

            partTimeStudentSubjects1.PrintEntities();

            //USING INDEX
            Subject thirdSubjectInList = SEDC.Students.Where(x => x.IsPartTime).SelectMany(x => x.Subjects).ToList()[2];

            //DISTINCT
            List<Subject> distinctSubjects =
                SEDC.Students.Where(x => x.IsPartTime).SelectMany(x => x.Subjects).Distinct().ToList();

            partTimeStudentSubjects1.PrintEntities();

            //ANY
            bool radmilaIsPartOfTheList = SEDC.Students.Any(x => x.FirstName == "Radmila");

            //ALL
            bool allNamesStartWithR = SEDC.Students.All(x => x.FirstName.StartsWith("R"));

            //UNION, EXCEPT, INTERSECT
            List<int> evenNumbers = new List<int>() { 2, 4, 6, 8 };
            List<int> oddNumbers = new List<int>() { 1, 3, 5, 7, 9 };

            List<int> numbers = evenNumbers.Union(oddNumbers).ToList();
            Console.WriteLine($"Average {numbers.Average()}");
            numbers.PrintSimple();

            List<int> randomNumbers = new List<int> {2, 3, 4, 5, 6, 7};
            List<int> numbers1 = evenNumbers.Except(randomNumbers).ToList();
            numbers1.PrintSimple();

            List<int> intersect = evenNumbers.Intersect(randomNumbers).ToList();
            intersect.PrintSimple();

            //ORDERING
            List<Student> sortedStudents = SEDC.Students.OrderBy(x => x.FirstName).ToList();
            sortedStudents.PrintEntities();

            List<Student> sortedStudentsDesc = SEDC.Students.OrderByDescending(x => x.FirstName).ToList();
            sortedStudentsDesc.PrintEntities();
            
            List<Student> sortedStudentsByFirstAndLastName = SEDC.Students.OrderBy(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            sortedStudentsByFirstAndLastName.PrintEntities();
            
            //SKIP/TAKE
            List<string> names = new List<string>() {"Goran", "Aleksandar", "Darko", "Dejan", "Risto", "Radmila", "Bojan", "Andrej", "Ivan", "Martin"};

            List<string> firstPage = Pagging<string>(names, 1, 3);
            List<string> secondPage = Pagging(names, 2, 3);
            List<string> thirdPage = Pagging(names, 3, 3);
            List<string> fourthPage = Pagging(names, 4, 3);
            List<string> fifthPage = Pagging(names, 5, 3);
        }

        public static List<T> Pagging<T>(List<T> list, int page, int pageSize)
        {
            return list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
