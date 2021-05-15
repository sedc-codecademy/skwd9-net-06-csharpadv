using AdvancedLINQ.Data;
using AdvancedLINQ.Entities;
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
            //SEDC.Students.PrintEntities();
            //SEDC.Subjects.PrintEntities();

            //SQLLikeExamples();

            AdvancedLINQExamples();


            Console.ReadLine();
        }

        public static void AdvancedLINQExamples() 
        {
            List<string> emptyListOfStrings = new List<string>();
            List<int> emptyListOfNums = new List<int>();

            // FIRST / SINGLE / LAST / ORDEFAULT
            // First => Gets first element, if no elements it will throw error
            // FirstOrDefault => Gets first element, if no elements will return default and will not throw error
            // Last => Gets last element, if no elements it will throw error
            // LastOrDefault => Gets last element, if no elements will return default and will not throw error
            // Single => Gets the only element from list, if more than one elements or no elements will throw error
            // SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

            var firstStudentInfo = SEDC.Students.First().Info();
            var firstThatStatsWithJInfo = SEDC.Students.First(student => student.FirstName.StartsWith("J")).Info();
            Console.WriteLine(firstStudentInfo);
            Console.WriteLine(firstThatStatsWithJInfo);

            //var firstThatStatsWithZInfo = SEDC.Students.First(student => student.FirstName.StartsWith("Z")).Info(); // will trow an ERROR

            var firstOrDefaultThatStatsWithZInfo = SEDC.Students.FirstOrDefault(student => student.FirstName.StartsWith("Z"));
            Console.WriteLine(firstOrDefaultThatStatsWithZInfo);

            Console.WriteLine(emptyListOfNums.FirstOrDefault(number => number == 5));

            Console.WriteLine(SEDC.Students.Single(student => student.FirstName == "Jill").Info());
            //Console.WriteLine(SEDC.Students.Single(student => student.FirstName == "Bob"));

            Console.WriteLine(SEDC.Students.SingleOrDefault(student => student.FirstName == "Viktor"));

            var space = SEDC.Students.SingleOrDefault(student => student.FirstName == "Viktor");

            Console.WriteLine($"one{space}two");


            // SELECT MANY
            // It flatens list of lists
            // Flattening => When we make one list out of multiple lists of the same type

            // Select
            List<List<Subject>> partTimeSubjectsSelect = SEDC.Students
                                                            .Where(x => x.IsPartTime)
                                                            .Select(y => y.Subjects).ToList();

            // SelectMany
            List<Subject> partTimeSubjectsSelectMany = SEDC.Students
                                                            .Where(x => x.IsPartTime)
                                                            .SelectMany(y => y.Subjects).ToList();

            partTimeSubjectsSelectMany.PrintEntities();

            // DISTINCT
            // Distinct will remove the duplicates in the List
            List<Subject> distinctSubjects = partTimeSubjectsSelectMany.Distinct().ToList();

            distinctSubjects.PrintEntities();

            // USING INDEX
            // The index is called on the List, not on the Linq query

            Subject partTimeSubject = SEDC.Students
                .Where(x => x.IsPartTime)
                .SelectMany(y => y.Subjects).ToList()[0];


            // ANY
            // Determines whether any element of a sequence exists or satisfies a condition
            // returns boolean

            bool isListEmpty = emptyListOfStrings.Any();
            emptyListOfStrings.Add("Viktor");
            isListEmpty = emptyListOfStrings.Any();

            bool isBob = SEDC.Students.Any(x => x.FirstName == "Bob");
            bool isDwayne = SEDC.Students.Any(x => x.FirstName == "Dwayne");

            // EXCEPT
            // Creates a new collection that is missing some particular items
            List<Student> exeptPartTime = SEDC.Students.Except(SEDC.Students.Where(x => x.IsPartTime == false)).ToList();

            // ALL
            // Determines whether all elements of a sequence satisfy a condition
            // returns boolean

            bool areThereShortNames = SEDC.Students.All(x => x.FirstName.Length >= 3);
            bool areAllFourCharacters = SEDC.Students.All(x => x.FirstName.Length == 4);


            // ORDERBY / ORDERBYDESCENDING / THENBY 
            List<Student> sordetStudents = SEDC.Students.OrderBy(x => x.FirstName).ToList();
            List<Student> sordetStudentsDesc = SEDC.Students.OrderByDescending(x => x.FirstName).ToList();

            List<Student> sordetStudentsThen = SEDC.Students.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ThenBy(x => x.Id).ToList();
        }

        public static void SQLLikeExamples() 
        {
            // WHERE //

            // Lambda 
            IEnumerable<Student> findBobsLambda = SEDC.Students.Where(student => student.FirstName == "Bob");
            findBobsLambda.ToList().PrintEntities();

            // SQL Like 
            IEnumerable<Student> findBobsSql = from student in SEDC.Students
                                               where student.FirstName == "Bob"
                                               select student;

            findBobsSql.ToList().PrintEntities();

            // SELECT //

            // Lambda 
            List<string> firstNamesLambda = SEDC.Students.Select(student => student.FirstName).ToList();
            firstNamesLambda.PrintSimple();

            List<string> fullNamesLambda = SEDC.Students.Select(student => $"{student.FirstName} {student.LastName}").ToList();
            fullNamesLambda.PrintSimple();

            // SQL Like 
            List<string> firstNamesSql = (from student in SEDC.Students
                                          select student.FirstName).ToList();

            firstNamesSql.PrintSimple();

            List<string> fullNamesSql = (from student in SEDC.Students
                                          select $"{student.FirstName} {student.LastName}").ToList();

            fullNamesSql.PrintSimple();
        }
    }
}
