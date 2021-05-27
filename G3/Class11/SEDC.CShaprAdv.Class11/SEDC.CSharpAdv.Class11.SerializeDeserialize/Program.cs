using Newtonsoft.Json;
using System;
using System.IO;

namespace SEDC.CSharpAdv.Class11.SerializeDeserialize
{
    class Program
    {
        static string directoryPath = @"..\..\..\OurData";
        static string filePath = directoryPath + @"\MyFirstJson.json";

        static ReaderWriter readerWriter = new ReaderWriter();
        static OurJsonSerializer ourJsonSerializer = new OurJsonSerializer();

        static void Main(string[] args)
        {
            #region Custom serializer deserializer
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Student bob = new Student
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 40,
                IsPartTime = false
            };
            //Console.WriteLine(bob.ToString());

            string bobString = ourJsonSerializer.SerializeStudent(bob);
            Console.WriteLine(bobString);
            readerWriter.WriteFile(filePath, bobString);

            string jsonString = readerWriter.ReadFile(filePath);
            Console.WriteLine(jsonString);

            Student student = ourJsonSerializer.DeserializeStudent(jsonString);

            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old, is part time {student.IsPartTime}");

            Student student1 = new Student
            {
                FirstName = "Trajan",
                LastName = "Stevkovski",
                Age = 22,
                IsPartTime = true
            };

            string studentStr = ourJsonSerializer.SerializeStudent(student1);
            readerWriter.WriteFile(filePath, studentStr);

            Console.ReadLine();

            string studentJson = readerWriter.ReadFile(filePath);
            Student student2 = ourJsonSerializer.DeserializeStudent(studentJson);

            Console.WriteLine($"{student2.FirstName} {student2.LastName} is {student2.Age} years old, is part time {student2.IsPartTime}");

            #endregion

            Console.WriteLine("====================JSON SERIALIZER====================");
            string njSerialization = JsonConvert.SerializeObject(bob);
            Console.WriteLine(njSerialization);

            var a = new
            {
                FullName = "Trajan Stevkovski",
                DateOfBirth = DateTime.Now
            };

            string njASerialized = JsonConvert.SerializeObject(a);
            Console.WriteLine(njASerialized);

            Console.WriteLine("====================JSON DESERIALIZER====================");

            Student student3 = JsonConvert.DeserializeObject<Student>(njSerialization);
            Console.WriteLine($"student3 {student3.FirstName} {student3.LastName} is {student3.Age} years old, is part time {student3.IsPartTime}");


            Console.ReadLine();
        }
    }
}
