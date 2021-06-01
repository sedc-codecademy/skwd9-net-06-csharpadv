using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace Exercise
{
    class Program
    {
        public static string FolderPath = @"../../../JsonData";
        public static string FilePath = Path.Combine(FolderPath, "data.json");

        static void Main(string[] args)
        {
            //string content = string.Empty;
            //using (HttpClient hp = new HttpClient())
            //{
            //    HttpResponseMessage message =
            //        hp.GetAsync("https://jsonplaceholder.typicode.com/todos/").Result;

            //    //message.EnsureSuccessStatusCode();

            //    if (message.StatusCode == HttpStatusCode.OK)
            //    {
            //        content = message.Content.ReadAsStringAsync().Result;
            //    }
            //}

            //WriteContent(content);

            string newContent = string.Empty;

            using (StreamReader sr = new StreamReader(FilePath))
            {
                string readContent = sr.ReadToEnd();

                List<Todo> todos = !string.IsNullOrEmpty(readContent)
                    ? JsonConvert.DeserializeObject<List<Todo>>(readContent)
                    : new List<Todo>();

                //todos.ForEach(x => Console.WriteLine(x.Title));

                //todos.ForEach(x => x.Title = $"C# Advance");

                foreach (Todo todo in todos)
                {
                    todo.Title = $"C# Advance";
                }

                newContent = JsonConvert.SerializeObject(todos);
            }
            
            WriteContent(newContent);
        }

        static void WriteContent(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                CreateFolder(FolderPath);
                CreateFile(FilePath);

                //using StreamWriter sw = new StreamWriter(FilePath);
                //sw.WriteLine(content);

                using (StreamWriter sw = new StreamWriter(FilePath))
                {
                    sw.WriteLine(content);
                }
            }
        }

        static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder created...");
            }
            else
            {
                Console.WriteLine("Folder exists...");
            }
        }

        static void CreateFile(string path)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
                Console.WriteLine("File created...");
            }
            else
            {

                Console.WriteLine("File exists...");
            }
        }
    }
}
