using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = Stopwatch.StartNew();

            var generator = new NameGenerator();
            //generator.Run();

            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);


            var names = generator.GenerateNames();

            names = names.Concat(names).Concat(names);
            names = names.Concat(names).Concat(names);
            names = names.Concat(names).Concat(names);
            names = names.Concat(names).Concat(names);
            names = names.Concat(names).Concat(names);
            names = names.Concat(names).Concat(names);
            names = names.Concat(names).Concat(names);

            //string jsonNames = "[\n";
            //foreach (var name in names)
            //{
            //    jsonNames += $"\t\"{name}\",\n";
            //}
            //jsonNames = jsonNames.Substring(0, jsonNames.Length - 2);
            //jsonNames += "\n]";

            //sw.Stop();
            //Console.WriteLine(jsonNames);
            //Console.WriteLine($"Count: {jsonNames.Length}");
            //Console.WriteLine($"Time: {sw.ElapsedMilliseconds}");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            foreach (var name in names)
            {
                sb.AppendLine($"\t\"{name}\",");
            }
            sb.Remove(sb.Length - 3, 2);
            sb.AppendLine("]");
            // Console.WriteLine(sb);
            string jsonNames = sb.ToString();

            sw.Stop();
            //Console.WriteLine(jsonNames);
            Console.WriteLine($"Time: {sw.ElapsedMilliseconds}");
            Console.WriteLine($"Count: {names.Count()}");

            Console.ReadLine();

        }
    }
}
