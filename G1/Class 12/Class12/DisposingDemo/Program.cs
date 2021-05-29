using System;
using System.IO;

namespace DisposingDemo
{
    class Program
    {
        public static string FolderPath = @"../../../Data";
        public static string FilePath = Path.Combine(FolderPath, "text.txt");

        static void Main(string[] args)
        {
            Console.WriteLine("App Start...");
            CreateFolder(FolderPath);
            CreateFile(FilePath);

            using (ICustomLogger logger = new CustomLogger(FilePath))
            {
                logger.LogError("Error happened");
                logger.LogError("Error 2 happened");
            }

            using (ICustomLogger logger = new CustomLogger(FilePath))
            {
                logger.LogInfo("Information happened");
                logger.LogError("Error 7 happened");
            }

            Console.ReadLine();
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
