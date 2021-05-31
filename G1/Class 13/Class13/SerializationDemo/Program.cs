using System;
using System.Collections.Generic;
using SerializationDemo.Entities;
using SerializationDemo.Helper;
using Newtonsoft.Json;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                Age = 32,
                Active = true,
                Subjects = new List<Subject>()
                {
                    new Subject()
                    {
                        Name = "C#",
                        Classes = 40
                    },
                    new Subject()
                    {
                        Name = "C# Advance",
                        Classes = 60
                    }
                }
            };

            #region Manual Serialization

            //Expected Result (JSON)
            //{"FirstName": "Risto", "LastName": "Panchevski", "Age": "32", "Active": "true"}
            Console.WriteLine("--------------------Manual--------------------");
            string manualSerialization = ManualSerializer.SerializeStudent(student);
            Console.WriteLine(manualSerialization);

            Student manualDeserialization = ManualSerializer.DeserializeStudent(manualSerialization);
            Console.WriteLine(manualDeserialization.FullName);

            #endregion

            #region System.Text.Json

            Console.WriteLine("--------------------System.Text.Json--------------------");

            string jsonSerialization = System.Text.Json.JsonSerializer.Serialize(student);
            Console.WriteLine(jsonSerialization);

            Student jsonDeserialization = System.Text.Json.JsonSerializer.Deserialize<Student>(jsonSerialization);
            Console.WriteLine(jsonDeserialization.FullName);

            #endregion

            #region Newtonsoft.JSON

            Console.WriteLine("--------------------Newtonsoft.JSON--------------------");
            string newtonsoftSerialization = JsonConvert.SerializeObject(student);
            Console.WriteLine(newtonsoftSerialization);

            Student newtonsoftDeserialization = JsonConvert.DeserializeObject<Student>(newtonsoftSerialization);
            Console.WriteLine(newtonsoftDeserialization?.FullName);


            //{"Ime": "Risto", "Prezime": "Panchevski", "Godini": "32", "Aktiven": "true"} => Uncomment the comments in Student.cs

            #endregion
        }
    }
}
