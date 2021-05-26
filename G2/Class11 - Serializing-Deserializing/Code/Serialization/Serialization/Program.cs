using Newtonsoft.Json;
using Serialization.Domain;
using Serialization.Helpers;
using Serialization.Services;
using System;
using System.IO;

namespace Serialization
{
    class Program
    {
        public static string Path = @"..\..\..\Data";
        public static string FilePath = Path+"\\data.json";
        static void Main(string[] args)
        {
            //MANUAL 

            //if (!Directory.Exists(Path))
            //{
            //    Directory.CreateDirectory(Path);
            //}
            //Student student = new Student()
            //{
            //    FirstName = "Bob",
            //    LastName = "Bobsky",
            //    Age = 22,
            //    IsPartTime = false
            //};
            //FileSystemService fileSystemService = new FileSystemService();
            //OurJsonSerializer ourJsonSerializer = new OurJsonSerializer();
            //string jsonResult = ourJsonSerializer.SerializeStudent(student);
            //Console.WriteLine(jsonResult);
            ////write to json file
            //fileSystemService.WriteInFile(FilePath, jsonResult);

            //Student deserializedStudent = ourJsonSerializer.DeserializeStudent(jsonResult);
            ////read from json file
            //string jsonStudent = fileSystemService.ReadFileContent(FilePath);
            //Student ourStudent = ourJsonSerializer.DeserializeStudent(jsonStudent);

            //LIBRARY -> NEWTONSOFT.JSON
            Student student = new Student()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 22,
                IsPartTime = false
            };
            string jsonString = JsonConvert.SerializeObject(student);
            Console.WriteLine(jsonString);

            Student deserializedStudent = JsonConvert.DeserializeObject<Student>(jsonString);
            Console.WriteLine(deserializedStudent.FirstName);

            Console.ReadLine();
        }
    }
}
