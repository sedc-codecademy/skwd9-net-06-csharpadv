using Newtonsoft.Json;
using SEDC.SerializeServices.Entities;
using SEDC.SerializeServices.Helpers;
using System;
using System.Collections.Generic;
using System.IO;

namespace SEDC.NewtonsoftSerialization
{
    class Program
    {
        static string folderPath = @"..\..\..\Data";
        static string filePath = folderPath + @"\data.json";

        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public static void CreateFile(string path)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
        }

        public static void PrintData(Student student)
        {
            Console.WriteLine($"FirstName: { student.FirstName }");
            Console.WriteLine($"LastName: { student.LastName }");
            Console.WriteLine($"Age: { student.Age }");
            Console.WriteLine($"IsPartTime: { student.IsPartTime }");
            Console.WriteLine("================================================");
        }

        static void Main(string[] args)
        {
            CreateFolder(folderPath);
            CreateFile(filePath);

            //Student dejan = new Student { FirstName = "Dejan", LastName = "Jovanov", Age = 28, IsPartTime = false };
            //Student ivo = new Student { FirstName = "Ivo", LastName = "Kostovski", Age = 30, IsPartTime = true };

            //string dejanString = JsonConvert.SerializeObject(dejan);
            //string ivoString = JsonConvert.SerializeObject(ivo);

            //Console.WriteLine(dejanString);
            //Console.WriteLine(ivoString);

            //ReaderWriter.WriteFile(filePath, dejanString);
            //ReaderWriter.WriteFile(filePath, ivoString);


            //Student dejanObj = JsonConvert.DeserializeObject<Student>(dejanString);
            //Student ivoObj = JsonConvert.DeserializeObject<Student>(ivoString);

            //PrintData(dejanObj);
            //PrintData(ivoObj);


            List<Student> students = new List<Student>()
            {
                new Student { FirstName = "Dejan", LastName = "Jovanov", Age = 28, IsPartTime = false },
                new Student { FirstName = "Ivo", LastName = "Kostovski", Age = 30, IsPartTime = true },
                new Student { FirstName = "Martin", LastName = "Panovski", Age = 28, IsPartTime = true },
            };

            string serializedStudentList = JsonConvert.SerializeObject(students);
            ReaderWriter.WriteFile(filePath, serializedStudentList);


            List<Student> studentsFromFile = JsonConvert.DeserializeObject<List<Student>>(serializedStudentList);
            foreach (var student in studentsFromFile)
            {
                PrintData(student);
            }

            Console.ReadLine();
        }
    }
}
