using System;
using System.Collections.Generic;
using System.IO;

namespace SDEC.CSharpAdv.Class09.FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string folderPath = currentDirectory + @"/files/";
            string fileName = "test.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Directory has been created");
            }

            if (!File.Exists(folderPath + fileName))
            {
                File.Create(folderPath + fileName).Close();
                Console.WriteLine("File has been created");
            }

            // here we handle the closing of the file
            StreamWriter sw = new StreamWriter(folderPath + fileName);
            sw.WriteLine("Hello SEDC!");
            sw.WriteLine("We are writing text from StreamWriter");
            Console.WriteLine("Writeing is complete");
            sw.Close();

            // using statement handles the closing of the file
            using (StreamWriter sw1 = new StreamWriter(folderPath + fileName))
            {
                sw1.WriteLine("Hello SEDC! from using statement");
                sw1.WriteLine("We are writing text from StreamWriter from using statement");
                sw1.WriteLine("This is written on top of the previos one");
                Console.WriteLine("Writeing is complete");
            }

            List<string> names = new List<string>
            {
                "Trajan",
                "Nikola",
                "Goran",
                "Biljana",
                "Code Academy1"
            };

            using (StreamWriter streamWriter = new StreamWriter(folderPath + fileName, true))
            {
                foreach (var name in names)
                {
                    streamWriter.WriteLine(name);
                }
            }



            Console.ReadLine();
        }
    }
}
