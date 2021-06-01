using SEDC.SerializeServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.SerializeServices.Helpers
{
    public static class CustomJsonSerializer
    {
        #region Process of serialization
        // This is a method that will convert a student object into a json like syntax
        // INPUT -> Student bob = new Student() { FirstName = "Bob" .....};
        // OUTPUT -> "{ "FirstName": "Bob", "LastName": "Bobsky", "Age": 28, "IsPartTime": true }"

        public static string SerializeStudent(Student student)
        {
            string json = "{";
            json += $"\"FirstName\": \"{student.FirstName}\",";
            json += $"\"LastName\": \"{student.LastName}\",";
            json += $"\"Age\": \"{student.Age}\",";
            json += $"\"IsPartTime\": \"{student.IsPartTime.ToString().ToLower()}\"";
            json += "}";

            return json;
        }
        #endregion

        #region Process of deserialization
        // This method will convert a string in json fromt into appropriate object representation
        // INPUT -> "{ "FirstName": "Bob", "LastName": "Bobsky", "Age": 28, "IsPartTime": true }"
        // OUTPUT -> Student bob = new Student() { FirstName = "Bob" .....};

        // 1. FirstName: Bob, LastName: Bobsky, Age: 22, IsPartTime: true
        // 1.1
        //  FirstName: Bob
        //  LastName: Bobsky
        //  Age: 22
        //  IsPartTime: true

        // Key: FirstName, Value: Bob
        // Key: LastName, Value: Bobsky
        // Key: Age, Value: 22
        // Key: IsPartTime, Value: true


        public static Student DeserializeStudent(string json)
        {
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(",");
            //[FirstName:Bob, LastName:Bobsky, Age:28, IsPartTime:true]

            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();
            foreach (var prop in properties)
            {
                string[] pair = prop.Split(":");
                // [FirstName, Bob]
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }


        #endregion


    }
}
