using LinqHelpers;
using LinqHelpers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ LINQ ------------

            // WHERE
            // Method syntax - with Lambda expression
            List<Student> findJillsLambda = SEDC.Students
                                        .Where(x => x.FirstName == "Jill")
                                        .ToList();
            //findJillsLambda.PrintEntities();

            // SQL syntax
            IEnumerable<Student> findJillsSql = from x in SEDC.Students
                               where x.FirstName == "Jill"
                               select x;
            //findJillsSql.ToList().PrintEntities();

            // SELECT
            // Method syntax - with Lambda expression
            List<string> firstNamesLambda = SEDC.Students
                                    .Select(x => x.FirstName)
                                    .ToList();
            List<string> fullNamesLambda = SEDC.Students
                                    .Select(x => $"{x.FirstName} {x.LastName}")
                                    .ToList();

            //firstNamesLambda.PrintSimple();
            //fullNamesLambda.PrintSimple();

            // SQL syntax
            List<string> firstNamesSql = (from x in SEDC.Students
                                          select x.FirstName).ToList();
            List<string> fullNamesSql = (from x in SEDC.Students
                                          select $"{x.FirstName} {x.LastName}").ToList();

            //firstNamesSql.PrintSimple();
            //fullNamesSql.PrintSimple();


            // COMPLEX QUERY
            // Method syntax
            List<Student> ptProgrLambda = SEDC.Students
                .Where(x => x.IsPartTime)
                .Where(x => x.Subjects.Where(y => y.Type == Academy.Programming).ToList().Count != 0)
                .ToList();
            //ptProgrLambda.PrintEntities();

            // SQL syntax
            List<Student> ptProgrSql = (from x in SEDC.Students
                                             where x.IsPartTime
                                             where (from y in x.Subjects
                                                    where y.Type == Academy.Programming
                                                    select y).ToList().Count != 0
                                             select x).ToList();
            //ptProgrSql.PrintEntities();


            // FIRST / SINGLE / LAST / ORDEFAULT
            // First => Gets first element, if no elements it will throw error
            // FirstOrDefault => Gets first element, if no elements will return default and will not throw error
            // Last => Gets last element, if no elements it will throw error
            // LastOrDefault => Gets last element, if no elements will return default and will not throw error
            // Single => Gets the only element from list, if more than one elements or no elements will throw error
            // SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

            List<string> emptyListOfStrings = new List<string>();
            List<int> emptyListOfNums = new List<int>();
            List<Student> emptyListOfStudents = new List<Student>();

            Console.WriteLine(SEDC.Students.First().Info());
            //Console.WriteLine(emptyListOfStrings.First()); // ERROR since there is no first item
            Console.WriteLine(emptyListOfStrings.FirstOrDefault() == null ? "I am null" : "I am NOT null");
            Console.WriteLine(emptyListOfNums.FirstOrDefault());
            Console.WriteLine(emptyListOfStudents.FirstOrDefault() == null ? "I am null" : "I am NOT null"); // null

            //Console.WriteLine(SEDC.Students.Single(x => x.Age > 30)); // ERROR since there are multiple results
            //Console.WriteLine(SEDC.Students.SingleOrDefault(x => x.Age > 30)); // ERROR since there are multiple results

            //Console.WriteLine(emptyListOfStudents.Single(x => x.Id == 100)); // ERROR since there is no matching element
            Console.WriteLine(emptyListOfStudents.SingleOrDefault(x => x.Id == 100) == null ? "I am null" : "I am NOT null");


            //// Console.WriteLine(emptyListOfStudents.FirstOrDefault().Id); // ERROR since we got null instead of a student

            // SELECT MANY
            // Flattens all child lists into one list

            //[ [1, 2], [3, 4], [5, [6, 7]] ] => [1, 2, 3, 4, 5, 6, 7]
            List<Subject> partTimeSubject = SEDC.Students
                                    .Where(x => x.IsPartTime)
                                    .SelectMany(x => x.Subjects)
                                    .ToList();
            partTimeSubject.PrintEntities();
            // Select
            //{
            // { Subject, Subject}, // List<Subject>
            // { Subject, Subject}
            //}
            // =>
            // SelectMany
            // { Subject, Subject, Subject....} List<Subject>
            //List<List<Subject>>

            Console.WriteLine("==================");

            // DISTINCT
            List<Subject> partTimeSubjectWithoutDuplicates = partTimeSubject
                                                            .Distinct()
                                                            .ToList();
            partTimeSubjectWithoutDuplicates.PrintEntities();

            // ORDERBY / ORDERBYDESCENDING / THENBY / THENBYDESCENDING
            Console.WriteLine("==================");
            List<Subject> orderedAscPartTimeSubject = partTimeSubjectWithoutDuplicates
                                                        .OrderBy(x => x.Id)
                                                        .ToList();
            orderedAscPartTimeSubject.PrintEntities();
            Console.WriteLine("==================");
            List<Subject> orderedDescPartTimeSubject = partTimeSubjectWithoutDuplicates
                                                        .OrderByDescending(x => x.Id)
                                                        .ToList();
            orderedDescPartTimeSubject.PrintEntities();

            // then by advanced ordering
            List<Subject> orderedByStudents = partTimeSubjectWithoutDuplicates
                                                .OrderBy(x => x.StudentsAttending)
                                                .ThenBy(x => x.Id)
                                                .ThenBy(x => x.Title)
                                                .ToList();
            orderedByStudents.PrintEntities();

            // ANY
            bool isBob = SEDC.Students
                            .Any(x => x.FirstName == "Bob");
            Console.WriteLine(isBob ? "Yes, there's Bob" : "There is no Bob");

            // ALL
            bool areNamesLongerThan3 = SEDC.Students
                                        .All(x => x.FirstName.Length > 3);
            Console.WriteLine(areNamesLongerThan3 ? "We're good" : "We have an intruder");

            // EXCEPT
            List<Student> exeptPartTime = SEDC.Students
                                    .Except(SEDC.Students.Where(x => x.IsPartTime)).ToList();
            exeptPartTime.PrintEntities();
            Console.ReadLine();
        }
    }
}
