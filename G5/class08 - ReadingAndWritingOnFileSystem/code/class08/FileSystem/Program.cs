using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory Manipulation

            // Check what folder is your application in
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            // Retrieve path to our application
            //relative path to the app
            string appPath = @"..\..\..\";

            //absolute path to the app
            string absoluteAppPath = @"C:\Users\viceb\Desktop\skwd9-net-06-csharpadv\G5\class08 - ReadingAndWritingOnFileSystem\code\class08\FileSystem";

            // Check if a folder on a specific path exists
            bool myFolderExists = Directory.Exists(appPath + "myFolder");

            // Create a new directory
            string newFolder = appPath + "myFolder";
            Console.WriteLine($"Does newFolder exists before: {Directory.Exists(newFolder)}");

            if (!Directory.Exists(newFolder)) 
            {
                Directory.CreateDirectory(newFolder);
                Console.WriteLine("myFolder was created!");
            }

            Console.WriteLine($"Does newFolder exists after: {Directory.Exists(newFolder)}");


            Console.WriteLine("Press enter if you want to delete myFolder");
            //Console.ReadLine();

            // Delete a directory
            //if (Directory.Exists(newFolder)) 
            //{
            //    Directory.Delete(newFolder);
            //    Console.WriteLine("myFolder was deleted!");
            //}


            // File Manipulation
            string filesPath = appPath + @"myFolder\";

            // File exists
            bool testTxtExists = File.Exists(filesPath + "test.txt");

            // File Create
            if (!File.Exists(filesPath + "test.txt")) 
            {
                File.Create(filesPath + "test.txt").Close();
                Console.WriteLine("new text document was created!");
            }

            Console.WriteLine("Press enter if you want to delete new text file");
            //Console.ReadLine();

            // File Delete
            //if (File.Exists(filesPath + "test.txt")) 
            //{
            //    File.Delete(filesPath + "test.txt");
            //    Console.WriteLine("File was deleted!");
            //}

            // Writing in a text file

            string testTxtPath = filesPath + "test.txt";
            if (File.Exists(testTxtPath)) 
            {
                File.WriteAllText(testTxtPath, "Hello from SEDC, we are writeing in a file");
                Console.WriteLine("Successfully written in a file ");
            }

            if (File.Exists(testTxtPath))
            {
                File.WriteAllText(testTxtPath, "Hello from SEDC, we are writeing in a file again");
                Console.WriteLine("Successfully written in a file ");
            }

            // Read from text file

            if (File.Exists(testTxtPath))
            {
                string content = File.ReadAllText(testTxtPath);
                Console.WriteLine("This is the text from the text file:");
                Console.WriteLine(content);
            }

            Console.ReadLine();
        }
    }
}
