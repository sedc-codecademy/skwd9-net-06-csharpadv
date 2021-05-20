using System;
using System.IO;

namespace SEDC.CSharpAdv.Class09.FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Directory Manipulation
            // Absolute path to application folder
            string currentDirectoryAbsolutePath = @"C:\SEDC\Sedc9\c# advanced\skwd9-net-06-csharpadv\G3\Class09\SEDC.CSharpAdv.Class09\SEDC.CSharpAdv.Class09.FileSystem\";

            string currentDirectory = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentDirectory);

            // Relative path to pur application
            string appPath = @"../../../";
            string folderName = "myFolder";

            bool myFolderExists = Directory.Exists(appPath + folderName);
            bool myFolderExistsAbsolute = Directory.Exists(currentDirectoryAbsolutePath + folderName);

            //Console.WriteLine($"Does {folderName} exitsts: {myFolderExists}");
            //Console.WriteLine($"Does {folderName} exitsts: {myFolderExistsAbsolute}");

            // Creating new folder
            string newFolderPath = appPath + "newFolder";
            Console.WriteLine($"Does newFolder exists before: {Directory.Exists(newFolderPath)}");
            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("New directory was created");
            }
            Console.WriteLine($"Does newFolder exists after: {Directory.Exists(newFolderPath)}");

            string folderPath = currentDirectory + @"\csharp_created_folder";
            Console.WriteLine($"Does newFolder exists before: {Directory.Exists(folderPath)}");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("New directory was created");
            }
            Console.WriteLine($"Does newFolder exists after: {Directory.Exists(folderPath)}");

            //Console.WriteLine("To delete folder press enter");
            //Console.ReadLine();

            //if (Directory.Exists(folderPath))
            //{
            //    Directory.Delete(folderPath);
            //    Console.WriteLine(@"csharp_created_folder was DELETED");
            //}

            Console.ReadLine();
            #endregion

            #region File Manipulation
            Console.WriteLine("=============== FILE MANIPULATION ================");

            string currentFileDirectory = Directory.GetCurrentDirectory();
            string fileFolderName = "files";

            string currentFileFolderPath = $@"{currentFileDirectory}\{fileFolderName}\";
            if (!Directory.Exists(currentFileFolderPath))
            {
                Directory.CreateDirectory(currentFileFolderPath);
                Console.WriteLine("New directory is created");
            }

            string fileName = "test.txt";
            bool testTxtFileExists = File.Exists(currentFileFolderPath + fileName);
            bool testTxt2FileExists = File.Exists(currentFileFolderPath + "test2.txt");
            //Console.WriteLine($"Does {fileName} exists: {testTxtFileExists}");
            //Console.WriteLine($"Does test2.txt exists: {testTxt2FileExists}");
            
            // Create file
            string studentsFileName = "students.txt";
            if(!File.Exists(currentFileFolderPath + studentsFileName))
            {
                File.Create(currentFileFolderPath + studentsFileName).Close();
                Console.WriteLine($"A file {studentsFileName} has been created");
            }

            // Delete file
            //if(File.Exists(currentFileFolderPath + studentsFileName))
            //{
            //    File.Delete(currentFileFolderPath + studentsFileName);
            //    Console.WriteLine($"File {studentsFileName} was deleted");
            //}

            // Writing in file
            string studentName = "Student Student1";
            if(File.Exists(currentFileFolderPath + studentsFileName))
            {
                File.WriteAllText(currentFileFolderPath + studentsFileName, studentName);
                Console.WriteLine("Successfuly written in file");
            }

            if (File.Exists(currentFileFolderPath + studentsFileName))
            {
                File.AppendAllText(currentFileFolderPath + studentsFileName, "Nikola Dalchevski");
                File.AppendAllText(currentFileFolderPath + studentsFileName, "Trajan Stevkovski");
                Console.WriteLine("Successfuly written in file");
            }

            Console.ReadLine();
            #endregion
        }
    }
}
