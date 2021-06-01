using SerializingAndDeserializing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerializingAndDeserializing.Services
{
    public class OurJsonSerializer
    {
        // Serialize a Student object
        public string SerializeStudent(Student student)
        {
            string json = "{";
            json += $"\"FirstName\" : \"{student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\",";
            json += "}";

            return json;
        }


        // Deserialize a Student object
        public Student DeserializeStudent(string json)
        {
            // THE PROCESS

            // Step 1
            //{
            //    "FirstName" : "Viktor",
            //    "LastName" : "Jakovlev",
            //    "Age" : "31",
            //    "IsPartTime" : false
            //}

            // Step 2
            // Cleaning the JSON

            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(",");

            // Step 3
            // Createing a new Dictionary
            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();

            // Step 4
            // Mapping the content from the JSON to the new Dictionary
            foreach (var property in properties)
            {
                string[] pair = property.Split(":");
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            // Step 5
            // Mapping the content of the Dictionary to a new Student class
            Student student = new Student()
            {
                FirstName = propertiesDictionary["FirstName"],
                LastName = propertiesDictionary["LastName"],
                Age = int.Parse(propertiesDictionary["Age"]),
                IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"])
            };

            return student;
        }


    }
}
