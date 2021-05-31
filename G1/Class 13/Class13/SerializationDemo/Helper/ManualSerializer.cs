using System.Collections.Generic;
using SerializationDemo.Entities;

namespace SerializationDemo.Helper
{
    public static class ManualSerializer
    {
        public static string SerializeStudent(Student student)
        {
            string json = "{";
            json += $"\"FirstName\": \"{student.FirstName}\",";
            json += $"\"LastName\": \"{student.LastName}\",";
            json += $"\"Age\": \"{student.Age}\",";
            json += $"\"Active\": \"{student.Active}\"";
            json += "}";

            return json;
        }

        //{"FirstName": "Risto", "LastName": "Panchevski", "Age": "32", "Active": "true"}
        public static Student DeserializeStudent(string json)
        {
            //string content = json.Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1);
            string content = json.TrimStart('{').TrimEnd('}')
            .Replace("\n", string.Empty)
            .Replace(" ", string.Empty)
            .Replace("\"", string.Empty);

            string[] sections = content.Split(',');

            Dictionary<string, string> properties = new Dictionary<string, string>();

            foreach (string section in sections)
            {
                string[] property = section.Split(':');

                properties.Add(property[0], property[1]);
            }

            return new Student()
            {
                FirstName = properties["FirstName"],
                LastName = properties["LastName"],
                Age = int.Parse(properties["Age"]),
                Active = bool.Parse(properties["Active"])
            };
        }
    }
}
