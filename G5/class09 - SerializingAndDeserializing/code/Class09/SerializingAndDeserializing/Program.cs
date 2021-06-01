using SerializingAndDeserializing.Entities;
using SerializingAndDeserializing.Services;
using System;
using System.IO;
using Newtonsoft.Json;

namespace SerializingAndDeserializing
{
    class Program
    {
        static string directoryPath = @"..\..\..\OurData";
        static string filePath = directoryPath + @"\myFirstJson.json";

        static OurJsonSerializer Serializer = new OurJsonSerializer();
        static ReaderWriterService ReaderWriter = new ReaderWriterService();

        static void Main(string[] args)
        {
            if (!Directory.Exists(directoryPath)) 
            {
                Directory.CreateDirectory(directoryPath);
            }


            Student viktor = new Student()
            {
                FirstName = "Viktor",
                LastName = "Jakovlev",
                Age = 31,
                IsPartTime = false
            };


            // manual serialization and deserialization
            string viktorString = Serializer.SerializeStudent(viktor);
            ReaderWriter.WriteFile(filePath, viktorString);
            string jsonStudent = ReaderWriter.ReadFile(filePath);

            Student deserializedStudent = Serializer.DeserializeStudent(jsonStudent);
            Console.WriteLine(deserializedStudent.FirstName);

            // using Newtonsoft.Json nugat package for serialization and deserialization

            string viktorStringNewtonsoft = JsonConvert.SerializeObject(viktor);

            User newUser = new User()
            {
                Username = "vjakovlev",
                Password = 123
            };

            string newUserStringNewtonsoft = JsonConvert.SerializeObject(newUser);
            //string newUserString = Serializer.SerializeStudent(newUser); will not work

            Student deserializedStudentNewtonsoft = JsonConvert.DeserializeObject<Student>(viktorStringNewtonsoft);
            Console.WriteLine(deserializedStudentNewtonsoft.FirstName);
        }
    }

    class User 
    {
        public string Username { get; set; }
        public int Password { get; set; }
    };
}
