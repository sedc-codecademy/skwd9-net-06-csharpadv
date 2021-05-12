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
            string filePath = folderPath + @"test.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("New directory was created!");
            }

            // Working with StreamWriter
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello SEDC!");
                sw.WriteLine("We are writing text from StreamWriter!");
                Console.WriteLine("We are done writing.");
            }

            // Second property is append (true for appending, false for rewritng)
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Hello again!");
                sw.WriteLine("We are writing NEW text from StreamWriter!");
                Console.WriteLine("Writing again");
            }

            // Reading with StreamReader

            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string restContent = sr.ReadToEnd();
                Console.WriteLine("First line is: {0}" ,firstLine);
                Console.WriteLine("Second line is: {0}", secondLine);
                Console.WriteLine("Rest of text is: {0}", restContent);
            }

            // 'using' syntax means that all connections will be closed after reading/writing to the file

            // old way of doing things
            // different syntax
            StreamReader sr2 = new StreamReader(filePath);
            string wholeText = sr2.ReadToEnd();
            // in order to work with the file you need to manually close the connection
            sr2.Close();
            // lines and line of code...
            Console.WriteLine("Whole text is: {0}", wholeText);
            Console.ReadLine();
        }
    }
}
