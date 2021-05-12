using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Directory Manipulation
            // Folders manipulation
            Console.WriteLine("---------- Directory manipulation ----------");

            // Check what folder is your application
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Current direcotry/folder is: {0}", currentDirectory);

            // Relative path to our application folder
            // slash depends on Windows or Mac
            // \ is for Windows
            // / is for Mac
            string appPath = @"..\..\..\";
            // Absolute path
            string appPathAbsolute = @"C:\Users\kristina\Desktop\Class08\Code\FileSystem\";
            // these two paths go to the same destination (FileSystem folder)

            // Check if folder exists
            bool myFolderExists = Directory.Exists(appPath + @"myFolder");
            bool myFolderExists02 = Directory.Exists(@"C:\Users\kristina\Desktop\Class08\Code\FileSystem\myFolder");
            Console.WriteLine("Does myFolder exist? {0}", myFolderExists);
            Console.WriteLine("Does myFolder exist? {0}", myFolderExists02);

            // Create a new folder
            string newFolderPath = appPath + @"newFolder";
            Console.WriteLine($"Does newFolder exists before? {Directory.Exists(newFolderPath)}");

            if (!Directory.Exists(newFolderPath))
            {
                // creation of the folder
                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("New folder was created!");
            }

            Console.WriteLine($"Does newFolder exists after? {Directory.Exists(newFolderPath)}");

            Console.WriteLine("Pess any key to delete the folder...");
            Console.ReadLine();

            // Delete a directory/folder
            if (Directory.Exists(newFolderPath))
            {
                Directory.Delete(newFolderPath);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("New folder was deleted!");
                Console.ResetColor();
            }
            #endregion

            #region File Manipulation
            Console.WriteLine("---------- Files manipulation ----------");

            string filesPath = appPath + @"myFolder\";
            if (!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
                Console.WriteLine("MyFolder was created!");
            }

            // File exists
            bool testTxtExists = File.Exists(filesPath + @"test.txt");
            Console.WriteLine("Does test.txt file exist? {0}", testTxtExists);

            // File Create
            if (!File.Exists(filesPath + @"test.txt"))
            {
                // File creation
                File.Create(filesPath + @"test.txt").Close();
                // if we do not put Close() here, the connection to the file will be active - you cannot rename, delete, open, etc
                Console.WriteLine("A file was created!");
            }
            //Console.WriteLine("Pess any key to delete the file...");
            //Console.ReadLine();

            //// Delete a file
            //if (File.Exists(filesPath + @"test.txt"))
            //{
            //    File.Delete(filesPath + @"test.txt");
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("The file was deleted!");
            //    Console.ResetColor();
            //}

            string textFile = filesPath + @"test.txt";

            // Write text in File
            if (File.Exists(textFile))
            {
                File.WriteAllText(textFile, "Hello SEDC! We are writing in a file...");
                Console.WriteLine("Successfully written in the file!");
            }
            Console.ReadLine();

            // Read from file
            if (File.Exists(textFile))
            {
                string content = File.ReadAllText(textFile);
                Console.WriteLine("This is the content:");
                Console.WriteLine(content);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
