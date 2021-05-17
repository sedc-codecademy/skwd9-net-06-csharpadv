using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);
            //Relative path
            string appPath = @"..\..\..\";
            //Abolsute path
            //C:\Personal\Academy\AdvancedCSharp\Code\Class09\FileSystem\FileSystem

            bool ourFolderExists = Directory.Exists(appPath + "ourFolder");
            bool ourFolderAbsolutePathExists =
                Directory.Exists(@"C:\Personal\Academy\AdvancedCSharp\Code\Class09\FileSystem\FileSystem\ourFolder");
            Console.WriteLine(ourFolderExists);
            Console.WriteLine(ourFolderAbsolutePathExists);

            string newFolderPath = appPath + "newFolder";
            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("newFolder was created!");
            }

            if (Directory.Exists(newFolderPath))
            {
                Directory.Delete(newFolderPath);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("newFolder deleted!");
                Console.ResetColor();
            }

            string filesPath = appPath + "filesFolder";
            if (!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
                Console.WriteLine("filesFolder created!");
            }

            bool testTxtExists = File.Exists(filesPath + @"\test.txt");
            Console.WriteLine(testTxtExists);

            if (!testTxtExists)
            {
                File.Create(filesPath + @"\test.txt").Close();
                Console.WriteLine("File test.txt created!");
            }

            //if (testTxtExists)
            //{
            //    File.Delete(filesPath + @"\test.txt");
            //    Console.WriteLine("File deleted!");
            //}

            if(File.Exists(filesPath + @"\test.txt"))
            {
                File.WriteAllText(filesPath + @"\test.txt", "Hello, we are writing for the first time!");
            }

            if (File.Exists(filesPath + @"\test.txt"))
            {
                File.WriteAllText(filesPath + @"\test.txt", "Hello, we are writing again!");
            }

            if(File.Exists(filesPath + @"\test.txt"))
            {
                string fileContent = File.ReadAllText(filesPath + @"\test.txt");
                Console.WriteLine("File content:");
                Console.WriteLine(fileContent);
            }

            Console.ReadLine();
        }
    }
}
