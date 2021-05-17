using System;
using System.IO;

namespace WorkingWithStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + "ourFolder";
            string filePath = folderPath + @"\test.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("ourFolder created!");
            }

            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello SEDC");
                sw.WriteLine("Hello SEDC from sw!");
                Console.WriteLine("Writing with sw first time completed!");
            }
            //sw does not exist

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Hello again");
                sw.WriteLine("Hello again from sw!");
            }
            //sw does not exist

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string firstLine = streamReader.ReadLine();
                string secondLine = streamReader.ReadLine();
                string restOfContent = streamReader.ReadToEnd();
                Console.WriteLine(secondLine);
                Console.WriteLine(restOfContent);
            }

                Console.ReadLine();
        }
    }
}
