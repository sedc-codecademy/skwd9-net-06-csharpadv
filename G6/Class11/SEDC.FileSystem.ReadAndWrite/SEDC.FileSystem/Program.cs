using System;
using System.IO;
using System.Threading;

namespace SEDC.FileSystem.ReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Directory manipulation - Directory class
            //string currentDirectory = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentDirectory);

            //// Absolute path - Absolute to our root folder of the console application
            //string absolutePath = @"D:\SEDC\2020-2021\AdvancedC#\skwd9-net-06-csharpadv\G6\Class11\SEDC.FileSystem.ReadAndWrite\SEDC.FileSystem\bin\Debug\netcoreapp3.1";
            //Console.WriteLine(absolutePath);


            //// Relative path - Relative to our application
            //string relativePath = @"..\..\..\";
            //Console.WriteLine(relativePath);


            //// Check if folder exists - By using Exists() method
            //bool myNewFolderExists = Directory.Exists(relativePath + @"myNewFolder");
            //bool myNewFolderExistsString = Directory.Exists(@"D:\SEDC\2020-2021\AdvancedC#\skwd9-net-06-csharpadv\G6\Class11\SEDC.FileSystem.ReadAndWrite\SEDC.FileSystem\myNewFolder");

            //Console.WriteLine(myNewFolderExists);
            //Console.WriteLine(myNewFolderExistsString);


            //// Create new folder - By using Create() method
            //string newFolderPath = relativePath + @"myNewFolder";
            //Console.WriteLine($"Does myNewFolder exists before : { Directory.Exists(newFolderPath) }");

            //if(!Directory.Exists(newFolderPath))
            //{
            //    Directory.CreateDirectory(newFolderPath);
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("New directory created successfully!");
            //    Console.ResetColor();
            //}
            //Console.WriteLine($"Does myNewFolder exists after : { Directory.Exists(newFolderPath) }");

            //Thread.Sleep(3000);

            //// Delete an existing directory - By using Delete() method
            //if(Directory.Exists(newFolderPath))
            //{
            //    Directory.Delete(newFolderPath);
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("myNewFolder deleted successfully!");
            //    Console.ResetColor();
            //}
            //#endregion


            //#region File manipulation - File class
            //string relativeAppPath = @"..\..\..\";
            //string filePath = relativeAppPath + @"newFolderWithFile";
            //string fullFilePath = filePath + @"\test.txt";

            //if (!Directory.Exists(filePath))
            //{
            //    Directory.CreateDirectory(filePath);
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("New directory created successfully!");
            //    Console.ResetColor();
            //}

            //Thread.Sleep(3000);

            //// File create - By using Create() method
            //// newFilderWithFile\test.txt

            //if(!File.Exists(fullFilePath))
            //{
            //    File.Create(fullFilePath).Close();
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("New file created successfully!");
            //    Console.ResetColor();
            //}

            ////Console.WriteLine("if you want to delete the file press any key...");
            ////Console.ReadLine();

            ////// File delete - By using Delete() method
            ////if(File.Exists(fullFilePath))
            ////{
            ////    File.Delete(fullFilePath);
            ////    Console.WriteLine("The file was deleted");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("The file is already deleted");
            ////}

            //// Write text content in a file - By using WriteAllText() method
            //if(File.Exists(fullFilePath))
            //{
            //    File.WriteAllText(fullFilePath, "Hello there! I just write in a file for the first time! \n");
            //    Console.WriteLine("Successfully written in a file!");
            //}

            //// Append new text content in the existing file - By using AppendAllText() method
            //if (File.Exists(fullFilePath))
            //{
            //    File.AppendAllText(fullFilePath, "Hello there again! I just write in a file for the second time!");
            //    Console.WriteLine("Successfully written in a file!");
            //}


            //Console.WriteLine("Do you want to read the content from the file? Enter 'y' or 'n'.");
            //string userInput = Console.ReadLine();

            //// Read the file content - By using ReadAllText() method
            //if(userInput.ToLower() == "y")
            //{
            //    string content = File.ReadAllText(fullFilePath);
            //    Console.WriteLine("The content from the test.txt file is: ");

            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine(content);
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.WriteLine("Okay! Have a nice day!");
            //}
            //#endregion




            // Example of create/write/read in a file and folder

            Console.WriteLine("Hi user! Choose what do you want to do!");
            Console.WriteLine("1) Create a directory \n2) ");

            int userChoise = Convert.ToInt32(Console.ReadLine());
            string relativeApplicationPath = @"..\..\..\";

            if(userChoise == 1)
            {
                Console.WriteLine("Please enter a valid name for your folder!");
                string folderName = Console.ReadLine();

                string fullPath = string.Format(@"{0}\{1}", relativeApplicationPath, folderName);

                if(!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                    Console.WriteLine($"New directory with name: { folderName } created successfully!");
                }
            }
            else if(userChoise == 2)
            {
                Console.WriteLine("Please enter a valid name for your file!");
                string fileName = Console.ReadLine();

                string fullFilePath = string.Format(@"{0}\{1}", relativeApplicationPath, fileName);

                if(!File.Exists(fullFilePath))
                {
                    File.Create(fullFilePath).Close();
                    Console.WriteLine($"New file with name: { fileName } created successfully!");
                }

                Console.WriteLine("Do you want to input some text in your file? Enter Y/N");
                string userTextInput = Console.ReadLine();

                if(userTextInput.ToLower() == "y")
                {
                    Console.WriteLine("Enter your text that you want to be stored in the file!");
                    string textContent = Console.ReadLine();

                    if(File.Exists(fullFilePath))
                    {
                        File.WriteAllText(fullFilePath, textContent);
                        Console.WriteLine("The text was successfully entered! Please check your file!");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong! The file probablu doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Thank you, have a nice day!");
                }
            }
            else
            {
                Console.WriteLine("Please enter appropriate input! Insert 1 or 2!");
            }




            Console.ReadLine();
        }
    }
}
