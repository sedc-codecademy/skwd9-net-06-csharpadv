using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class11.SerializeDeserialize
{
    public class OurJsonSerializer
    {

        //{"FirstName" : "Bob","LastName" : "Bobsky","Age" : "40","IsPartTime" : "false"}
        public string SerializeStudent(Student student)
        {
            string json = "{";
            json += $"\"FirstName\" : \"{student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\"";
            json += "}";

            return json;
        }

        public Student DeserializeStudent(string json)
        {
            // The process
            /*
            0. { "FirstName" : "Bob"\r\n,"LastName" : "Bobsky","Age" : "40","IsPartTime" : "false" }
            1. "FirstName" : "Bob","LastName" : "Bobsky","Age" : "40","IsPartTime" : "false"
            1.1
            FirstName : Bob
            LastName : Bobsky
            Age : 40
            IsPartTime : false
            2.
            Key: FirstName ,Value: Bob
            Key: LastName ,Value: Bobsky
            Key: Age ,Value: 40
            Key: IsPartTime ,Value: false
            3.
            Create and assing values to Student object
             */

            // 0. Clearing json string
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            Console.WriteLine("DESERIALIZING");
            Console.WriteLine(content);
            // FirstName : Bob,LastName : Bobsky,Age : 40,IsPartTime : false

            string[] properties = content.Split(",");
            //FirstName: Bob
            //LastName : Bobsky
            //Age : 40
            //IsPartTime: false

            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();
            foreach (var property in properties)
            {
                string[] pair = property.Split(":");
                // [FirstName, Bob] - first ittreration
                // [LastName, Bobsky] - second ittreration
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }
    }


}
