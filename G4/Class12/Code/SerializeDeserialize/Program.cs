using SerializeDeserialize.Entities;
using System;
using System.IO;
using Newtonsoft.Json;

namespace SerializeDeserialize
{
    class Program
    {
        static string directoryPath = @"..\..\..\OurData";
        static string filePath = directoryPath + @"\myFirstJson.json";
        static OurJsonSerializer SerializerDeserializer = new OurJsonSerializer();
        static ReaderWriter ReaderWriter = new ReaderWriter();
        static void Main(string[] args)
        {
            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

            #region Our Serialize / Deserialize methods

            // Poor man's Serialize / Deserialize
            Student bob = new Student()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 33,
                IsPartTime = false
            };

            User myUser = new User()
            {
                Username = "kiki123",
                Password = "netikazuvam"
            };

            string bobString = SerializerDeserializer.SerializeStudent(bob);
            //Console.WriteLine(bobString);
            ReaderWriter.WriteFile(filePath, bobString);

            string jsonStudent = ReaderWriter.ReadFile(filePath);
            Student deserializedStudent = SerializerDeserializer.DeserializeStudent(jsonStudent);
            Console.WriteLine(deserializedStudent.FirstName);
            #endregion

            #region Newtonsoft JSON serialize / deserialize
            Console.WriteLine("----------- Newtonsoft JSON ------------");
            string bobSerializedNewtonsoft = JsonConvert.SerializeObject(bob);
            string userSerializeNewtonsoft = JsonConvert.SerializeObject(myUser);
            Console.WriteLine(bobSerializedNewtonsoft);
            Console.WriteLine(userSerializeNewtonsoft);

            Student deserializedBobNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerializedNewtonsoft);
            Console.WriteLine(deserializedBobNewtonsoft.LastName);
            User deserializedUserNewtonsoft = JsonConvert.DeserializeObject<User>(userSerializeNewtonsoft);
            Console.WriteLine(deserializedUserNewtonsoft.Password);
            #endregion
            Console.ReadLine();
        }
    }
}
