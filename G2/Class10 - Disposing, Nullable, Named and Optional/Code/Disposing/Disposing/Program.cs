using Disposing.InputOutputHelpers;
using System;
using System.IO;

namespace Disposing
{
    class Program
    {
        public static string AppPath = @"..\..\..\Text";
        public static string FilePath = AppPath + @"\text.txt";

        public static void CreateFolder()
        {
            if (!Directory.Exists(AppPath))
            {
                Directory.CreateDirectory(AppPath);
            }
        }

        public static void CreateFile()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
        }

        public static void AppendTextInFile(string text)
        {
            OurWriter ourWriter = new OurWriter(FilePath);
            ourWriter.Write(text);
            ourWriter.Dispose();
        }

        public static string ReadFromFile()
        {
            OurReader ourReader = new OurReader(FilePath);
            string text = ourReader.Read();
            ourReader.Dispose();
            return text;
        }
        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();
            //MANUAL DISPOSE (.Dispose())
            AppendTextInFile("Hello spring!");
            AppendTextInFile("We are already done with C#");

            Console.WriteLine(ReadFromFile());

            //DISPOSE WITH USING, calls Dispose in the background
            using(OurReader reader = new OurReader(FilePath))
            {
                Console.WriteLine(reader.Read());
            }
            Console.ReadLine();
        }
    }
}
