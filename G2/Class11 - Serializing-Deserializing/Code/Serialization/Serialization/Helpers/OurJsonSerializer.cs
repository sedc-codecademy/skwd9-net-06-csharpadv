using Serialization.Domain;
using System.Collections.Generic;

namespace Serialization.Helpers
{
    public class OurJsonSerializer
    {
        public string SerializeStudent(Student student)
        {
            string jsonResult = "{";
            jsonResult += $"\"FirstName\" : \"{student.FirstName}\",";
            jsonResult += $"\"LastName\" : \"{student.LastName}\",";
            jsonResult += $"\"Age\" : \"{student.Age}\",";
            jsonResult += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\"";
            jsonResult += "}";

            return jsonResult;
        }

        public Student DeserializeStudent(string jsonString)
        {
            string content = jsonString
                .Substring(jsonString.IndexOf("{") + 1, jsonString.IndexOf("}") - 1)
                .Replace("\n", "")
                .Replace("\r", "")
                .Replace("\"", "");

            string[] properties = content.Split(',');
            Dictionary<string, string> results = new Dictionary<string, string>();
            foreach(string property in properties)
            {
                string[] pair = property.Split(':');
                results.Add(pair[0].Trim(), pair[1].Trim());
            }

            Student student = new Student();
            student.FirstName = results["FirstName"];
            student.LastName = results["LastName"];
            student.Age = int.Parse(results["Age"]);
            student.IsPartTime = bool.Parse(results["IsPartTime"]);

            return student;
        }
    }
}
