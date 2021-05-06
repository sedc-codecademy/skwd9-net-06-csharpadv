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

            Console.ReadLine();
        }
    }
}
