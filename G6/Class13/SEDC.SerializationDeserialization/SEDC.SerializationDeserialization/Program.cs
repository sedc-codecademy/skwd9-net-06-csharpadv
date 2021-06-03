using SEDC.SerializeServices.Entities;
using SEDC.SerializeServices.Helpers;
using System;
using System.IO;

namespace SEDC.SerializationDeserialization
{
    class Program
    {
        static string folderPath = @"..\..\..\OurData";
        static string filePath = folderPath + @"\myFirstJson.json";

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

        static void Main(string[] args)
        {
            Student martin = new Student { FirstName = "Martin", LastName = "Panovski", Age = 27, IsPartTime = true };

            // Serialization of C# object
            string martinString = CustomJsonSerializer.SerializeStudent(martin);
            Console.WriteLine(martinString);

            // Deserialization of json string into C# object
            Student martinDeserialized = CustomJsonSerializer.DeserializeStudent(martinString);
            Console.WriteLine(martinDeserialized.FirstName);
            Console.WriteLine(martinDeserialized.LastName);


            Student petre = new Student { FirstName = "Petre", LastName = "Arsovski", Age = 25, IsPartTime = true };
            CreateFolder(folderPath);
            CreateFile(filePath);

            string jsonStudent = CustomJsonSerializer.SerializeStudent(petre);
            ReaderWriter.WriteFile(filePath, jsonStudent);


            string studentFromFile = ReaderWriter.ReadFile(filePath);

            Student studentParsed = CustomJsonSerializer.DeserializeStudent(studentFromFile);

            Console.WriteLine($"Hello there this is the student read from the file: {studentParsed.FirstName}");



            Console.ReadLine();
        }
    }
}
