using System;
using System.IO;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + @"myFolder\";
            string filePath = folderPath + "text.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("New directory was created!");
            }

            // Writing with StramWriter

            using (StreamWriter sw = new StreamWriter(filePath)) 
            {
                sw.WriteLine("Hello Again");
                sw.WriteLine("We are writing from the stream writer!");
                Console.WriteLine("Writing is complete!");
            }

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Hello Again");
                sw.WriteLine("We are writing from the stream writer again!");
                Console.WriteLine("Writing again!");
            }

            // Reading with StreamReader

            using (StreamReader sr = new StreamReader(filePath)) 
            {
                string firstLine = sr.ReadLine();
                Console.WriteLine(firstLine);

                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}
