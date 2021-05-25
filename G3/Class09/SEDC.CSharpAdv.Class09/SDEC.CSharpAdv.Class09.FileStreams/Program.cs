using SDEC.CSharpAdv.Class09.FileStreams.Logger;
using System;
using System.Collections.Generic;
using System.IO;

namespace SDEC.CSharpAdv.Class09.FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoggerTest();
            //Console.ReadLine();
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

            StreamReader streamReader = new StreamReader(folderPath + fileName);
            string firstLine = streamReader.ReadLine();
            Console.WriteLine(firstLine);
            streamReader.Close();

            using (StreamReader sr = new StreamReader(folderPath + fileName))
            {
                string firstLine1 = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string thirdLine = sr.ReadLine();
                string rest = sr.ReadToEnd();

                Console.WriteLine($"First line: {firstLine1}");
                Console.WriteLine($"Second line: {secondLine}");
                Console.WriteLine($"Third line: {thirdLine}");
                Console.WriteLine($"Rest: {rest}");
            }

            // result for exercise 2 + 3 = 5 - 05 / 20 / 2021 20:09:23

            Console.ReadLine();
        }


        public static void LoggerTest()
        {
            ILogerService loger = new LoggerService();

            loger.LogUsage("trajan", false);
            loger.LogError("failed to load database", "connection failed", "trajan");
            loger.LogUsage("trajan", true);
        }
    }
}
