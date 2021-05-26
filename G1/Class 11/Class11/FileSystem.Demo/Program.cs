using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileSystem.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Paths

            ////absolute path: C:\SEDC\Materials\SEDC\2020-2021\New Materials\Advance C#\StudentsCode\G1\Class 11\Class11\FileSystem.Demo\bin\Debug\netcoreapp3.1\Data

            ////relative path
            //string currentDirectory = Directory.GetCurrentDirectory();

            ////going deep in the folder structure
            //string path = currentDirectory + @"\Data";
            //Console.WriteLine(currentDirectory);
            //Console.WriteLine(path);

            ////going upper in the folder tree
            //string levelUp = @"..\..\Data";

            #endregion

            #region Directory

            string appPath = @"..\..\..\";
            //string appPathAbsolute =
            //    @"C:\SEDC\Materials\SEDC\2020-2021\New Materials\Advance C#\StudentsCode\G1\Class 11\Class11\FileSystem.Demo\";

            //bool existsFolderNamedData = Directory.Exists(appPath + "Data");
            //bool existsFolderNamedData = Directory.Exists(appPath + "Data");

            //bool existsFolderNamedData = Directory.Exists(Path.Combine(appPath, "Data"));


            //if (existsFolderNamedData)
            //{
            //    Console.WriteLine("Directory with name Data exists");
            //}
            //else
            //{
            //    Console.WriteLine("Directory with name Data does exists");
            //}

            //string newFolderPath = Path.Combine(appPath, "newFolder");

            //string folderExistText = Directory.Exists(newFolderPath) ? "exists" : "does not exist";
            //Console.WriteLine($"Folder {newFolderPath}: {folderExistText}");

            //if (!Directory.Exists(newFolderPath))
            //{
            //    Directory.CreateDirectory(newFolderPath);
            //    Console.WriteLine($"Folder {newFolderPath} created");
            //}

            //Console.WriteLine($"Enter any key if you want folder {newFolderPath} to be deleted");
            //Console.ReadLine();

            //if (Directory.Exists(newFolderPath))
            //{
            //    //will remove the directory only if it is empty
            //    //Directory.Delete(newFolderPath);
            //    //removes the directory with all nested folders and files
            //    Directory.Delete(newFolderPath, true);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Folder {newFolderPath} deleted");
            //    Console.ResetColor();
            //}

            #endregion

            string filesPath = Path.Combine(appPath, "Files\\");

            if (!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
            }

            string firstFilePath = Path.Combine(filesPath, "file1.txt");

            if (!File.Exists(firstFilePath))
            {
                File.Create(firstFilePath).Close();
            }

            //if (File.Exists(firstFilePath))
            //{
            //    File.Delete(firstFilePath);
            //}

            //File.WriteAllText(firstFilePath, "Welcome to Advance C#");
            //will erase previous content of the file
            //File.WriteAllText(firstFilePath, "Next subject is Database");

            File.AppendAllText(firstFilePath, "First text\n");
            File.AppendAllText(firstFilePath, "Second text\n");
            
            //File.AppendAllLines(firstFilePath, new List<string>() { "First line" });
            //File.AppendAllLines(firstFilePath, new List<string>() { "Second line" });

            File.Copy(firstFilePath, Path.Combine(filesPath, "fileCopy.txt"), true);

            if(File.Exists(Path.Combine(filesPath, "fileCopy.txt")))
            {
                string content = File.ReadAllText(Path.Combine(filesPath, "fileCopy.txt"));
                List<string> lines = File.ReadAllLines(Path.Combine(filesPath, "fileCopy.txt")).ToList();
            }

            //File.Create(Path.Combine(filesPath, "d.docx"));
        }
    }
}
