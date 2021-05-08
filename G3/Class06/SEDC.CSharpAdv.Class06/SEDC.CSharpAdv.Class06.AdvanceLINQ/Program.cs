using SEDC.CSharpAdv.Class06.Domain;
using SEDC.CSharpAdv.Class06.Domain.Entities;
using SEDC.CSharpAdv.Class06.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpAdv.Class06.AdvanceLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // get all rekords that first name is Bob
            // method syntax
            IEnumerable<Student> findBob = Database.Students.Where(x => x.FirstName == "Bob");
            //findBob.ToList().PrintEntities();

            var trajan = "" == "";

            // SQL syntax
            IEnumerable<Student> findBobSQLSyntax = from student in Database.Students
                                                    where student.FirstName == "Bob"
                                                    select student;
            //findBobSQLSyntax.ToList().PrintEntities();

            Func<Student, bool> findBobFnc = student => student.FirstName == "Bob";
            IEnumerable<Student> findBobWithFunc = Database.Students.Where(findBobFnc);
            //findBobWithFunc.ToList().PrintEntities();

            // Get part time student that are on academy for programing
            // Query syntax
            var partTimeStudentOnProgramingQuerySyntax =
                from student in Database.Students
                where student.IsPartTime
                where (from subject in student.Subjects
                       where subject.Type == Academy.Programming
                       select subject).ToList().Count != 0
                select student;
            //partTimeStudentOnProgramingQuerySyntax.ToList().PrintEntities();

            // Method syntax
            var partTimeStudentOnProgramingMethodSyntax = Database.Students
                .Where(student => student.IsPartTime)
                .Where(student => student.Subjects
                    .Where(subject => subject.Type == Academy.Programming)
                    .ToList().Count != 0)
                .ToList();
            //partTimeStudentOnProgramingMethodSyntax.PrintEntities();

            var secondPartTimeStudentOnProgramingMethodSyntax = Database.Students
                .Where(student => student.IsPartTime && student.Subjects
                    .Where(subject => subject.Type == Academy.Programming).ToList().Count != 0)
                .ToList();
            //secondPartTimeStudentOnProgramingMethodSyntax.PrintEntities();
            var thirdPartTimeStudentOnProgramingMethodSyntax = Database.Students
                .Where(student => student.IsPartTime && student.Subjects
                    .Count(subject => subject.Type == Academy.Programming) != 0)
                .ToList();
            //thirdPartTimeStudentOnProgramingMethodSyntax.PrintEntities();

            // First
            var firstRecord = Database.Students.First();
            // var firstRecord1 = Database.Students.First(std => std.FirstName == "z");

            // First or default
            var firstOrDefaultRecord = Database.Students.FirstOrDefault();
            var firstOrDefaultRecord1 = Database.Students.FirstOrDefault(std => std.FirstName == "z");

            // Single
            //var singleRecord = Database.Students.Single();
            var singleRecord1 = Database.Students.Single(x => x.FirstName == "Trajan");

            // Single or default
            //var singleOrDefaultRecord = Database.Students.SingleOrDefault();
            var singleOrDefaultRecord1 = Database.Students.SingleOrDefault(x => x.FirstName == "z");

            // Last
            var lastRecord = Database.Students.Last();
            //var lastRecord1 = Database.Students.Last(x => x.FirstName == "z");

            // Last or default
            var lastOrDefaultRecord = Database.Students.LastOrDefault();
            var lastOrDefaultRecord1 = Database.Students.LastOrDefault(x => x.FirstName == "z");

            // Any
            // check if collection contains elements
            bool anyRecord = Database.Students.Any();
            bool anyRecord1 = Database.Students.Any(x => x.FirstName == "Bob");
            bool anyRecord2 = Database.Students.Any(x => x.Age > 20);

            if(Database.Students.Any(x => x.IsPartTime))
            {
                //Console.WriteLine("Im in if");
            }

            // All
            // Checks if all collection elements satisfy some condition
            bool allRecord = Database.Students.All(x => x.FirstName == "Trajan");
            bool allRecord1 = Database.Students.All(x => x.FirstName.Length >= 3);

            // Group By
            // Groups elements by property
            IEnumerable<IGrouping<int, Student>> groupByAge = Database.Students.GroupBy(x => x.Age);

            //foreach (var item in groupByAge)
            //{
            //    Console.WriteLine("---------------------------");
            //    Console.WriteLine("Age: " + item.Key);
            //    foreach (var element in item)
            //    {
            //        Console.WriteLine(element.Info());
            //    }
            //}

            var groupByPartTime = Database.Students.GroupBy(x => x.IsPartTime);

            // Intersect
            // Gets all elements that are conitained in both collections
            var modules = Database.Subjects.Select(x => x.Modules);
            var attendings = Database.Subjects.Select(x => x.StudentsAttending);

            var intersect = modules.Intersect(attendings);

            var intersect1 = Database.Subjects
                .Select(x => x.Modules)
                .Intersect(Database.Subjects
                    .Select(x => x.StudentsAttending));

            // Union
            // Gets all unique elements in both collections
            var union = modules.Union(attendings);

            // SelectMany
            // Flatens collections
            List<List<int>> listOfInts = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4},
                new List<int> { 11, 22, 33, 44},
                new List<int> { 111, 222, 333, 444 },
                new List<int> { 1111, 2222, 3333, 4444 }
            };
            List<int> listOfIntegers = new List<int>();
            foreach (var itemList in listOfInts)
            {
                foreach (var element in itemList)
                {
                    listOfIntegers.Add(element);
                }
            }

            var selectMany = listOfInts.SelectMany(x => x);

            List<List<Subject>> studentSubjcets = Database.Students.Select(x => x.Subjects).ToList();
            List<Subject> studentSubjcets1 = Database.Students.SelectMany(x => x.Subjects).ToList();

            // Average
            double ageAvarage = Database.Students.Average(x => x.Age);

            // Concat
            var concatenatedLists = modules.Concat(attendings);

            // Count
            int count = Database.Students.Count(x => x.IsPartTime);

            // Distinct
            var distinctModules = Database.Subjects.Select(x => x.Modules).Distinct();

            // Except
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 3, 4, 6, 7, 8 };

            var except = list1.Except(list2).ToList();

            // OrderBy
            var orderByAge = Database.Students.OrderBy(x => x.Age);
            var orderByAgeDescending = Database.Students.OrderByDescending(x => x.Age);

            // Take and Skip
            var first2Stdents = Database.Students.Take(2); //0,1
            var skip2Take3 = Database.Students.Skip(2).Take(3); //skip 0,1 take 2,3,4 

            // ToDictionary
            var toDictionary = Database.Students.ToDictionary(key => key.Id, value => value);
            var toDictionary1 = Database.Students.ToDictionary(key => key.FirstName, value => value.Subjects);

            var abc = Database.Students.Select(x => new { x.FirstName, x.Subjects });

            Console.ReadLine();
        }
    }
}
