using System;
using System.IO;

namespace SEDC.FileSystem.StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String.Format() reminder
            //string fName = "Martin";
            //string lName = "Panovski";
            //string fullName = fName + " " + lName;

            //string fullNameInterpolation = $"{ fName } { lName }";
            //string fullNameFormat = string.Format("{0} {1}", fName, lName);
            #endregion

            string appPath = @"..\..\..\";
            string folderPath = appPath + @"StreamReaderAndWriter";
            string filePath = folderPath + @"\StreamReadAndWrite.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder created!");
            }

            //// Write in a file using StreamWriter
            //using (StreamWriter sw = new StreamWriter(filePath))
            //{
            //    sw.WriteLine("Hello SEDC!");
            //    sw.WriteLine("We are learning how to write in a file!");
            //    Console.WriteLine("Writing is completed");
            //}

            //// Writing without rewriting the document with StreamWriter
            //using (StreamWriter sw = new StreamWriter(filePath, true))
            //{
            //    sw.WriteLine("Hello again!");
            //    sw.WriteLine("We are learning how to write in a file once again and it is really cool!");
            //    Console.WriteLine("Writing is completed!");
            //}

            // Reading from a file
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string firstLine = sr.ReadLine();
                    string secondLine = sr.ReadLine();
                    string thirdLine = sr.ReadLine();

                    Console.WriteLine($"First line: { firstLine }");
                    Console.WriteLine($"Second line: { secondLine }");
                    Console.WriteLine($"Third line: { thirdLine }");

                    string content = sr.ReadToEnd();
                    Console.WriteLine($"The content of the file is: { content }");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured! Message { ex.Message }");
            }
            Console.ReadLine();
        }
    }
}
