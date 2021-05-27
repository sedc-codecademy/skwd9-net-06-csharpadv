using System;
using System.IO;

namespace FileStreams.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = Directory.GetCurrentDirectory();
            string filesPath = Path.Combine(appPath, "Data\\");
            string filePath = Path.Combine(filesPath, "test.txt");

            //StreamReader sr = new StreamReader(filePath);
            //string firstLine = sr.ReadLine();
            //string secondLine = sr.ReadLine();
            //string restOfTheContent = sr.ReadToEnd();

            //Console.WriteLine($"First line: {firstLine}");
            //Console.WriteLine($"Second line: {secondLine}");
            //Console.WriteLine($"Rest lines: {restOfTheContent}");

            ////string line = sr.ReadLine();
            ////while (line != null)
            ////{
            ////    //Do something with the line



            ////    //Go to next line
            ////    line = sr.ReadLine();
            ////}


            ////sr.Close();
            //sr.Dispose();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string restOfTheContent = sr.ReadToEnd();

                Console.WriteLine($"First line: {firstLine}");
                Console.WriteLine($"Second line: {secondLine}");
                Console.WriteLine($"Rest lines: {restOfTheContent}");
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello SEDC!");
                sw.WriteLine(Console.ReadLine());
            }

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("New text from appender");
                sw.WriteLine(Console.ReadLine());
            }
        }
    }
}
