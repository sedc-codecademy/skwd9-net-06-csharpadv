using System;
using System.IO;

namespace SEDC.ClassDispose.Disposing
{
    class Program
    {
        // Path to a folder
        public static string FolderPath = @"..\..\..\Text";

        // Path to a file in that folder .txt
        public static string FilePath = string.Format(@"{0}\{1}", FolderPath, @"\text.txt");

        // Add method for creating a folder
        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        // Add method for creating a file
        public static void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        //#region Manual Dispose Methods
        //// Add method for append text in a file
        //public static void AppendTextInFile(string text, string path)
        //{
        //    StreamWriter sw = new StreamWriter(path, true);
        //    if (text.Contains("break"))
        //        throw new Exception("Something went wrong....");
        //    sw.WriteLine(text);
        //    sw.Dispose();
        //}

        //// Add method for read text from file
        //public static void ReadTextFromFile(string path)
        //{
        //    StreamReader sr = new StreamReader(path);
        //    Console.WriteLine(sr.ReadToEnd());
        //    sr.Dispose();
        //}

        //// Add method for demo of the previous code
        //public static void ManualExample()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter text pt1:");
        //        string text1 = Console.ReadLine();
        //        AppendTextInFile(text1, FilePath);

        //        Console.WriteLine("Enter text pt2:");
        //        string text2 = Console.ReadLine();
        //        AppendTextInFile(text2, FilePath);

        //        Console.WriteLine("Enter text pt3:");
        //        string text3 = Console.ReadLine();
        //        AppendTextInFile(text3, FilePath);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("There was a problem in the writing system!");
        //        Console.WriteLine(ex.Message);
        //    }


        //    try
        //    {
        //        Console.ReadLine();
        //        Console.WriteLine("-------- Read --------");
        //        ReadTextFromFile(FilePath);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("There was a problem in the reading system!");
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //#endregion

        //#region Dispose by using 'Using statement'
        //public static void AppendTextInFileSafe(string text, string path)
        //{
        //    using (StreamWriter sw = new StreamWriter(path, true))
        //    {
        //        if (text.Contains("break"))
        //            throw new Exception("Something broke unexpectedly...");
        //        sw.WriteLine(text);
        //    }
        //}
        //public static void ReadTextFromFileSafe(string path)
        //{
        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        Console.WriteLine(sr.ReadToEnd());
        //    }
        //}

        //public static void UsingExample()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter text pt1:");
        //        string text1 = Console.ReadLine();
        //        AppendTextInFileSafe(text1, FilePath);

        //        Console.WriteLine("Enter text pt2:");
        //        string text2 = Console.ReadLine();
        //        AppendTextInFileSafe(text2, FilePath);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("There was a problem in the writing system");
        //        Console.WriteLine(ex.Message);
        //    }


        //    Console.ReadLine();
        //    Console.WriteLine("------- Read ---------");
        //    ReadTextFromFileSafe(FilePath);
        //}

        //#endregion

        #region Dispose by using our custom Writer/Reader
        public static void AppendTextInFileCustom(string text, string path)
        {
            using (OurWriter ow = new OurWriter(path))
            {
                if (text.Contains("break"))
                    throw new Exception("Something happend!");
                ow.Write(text);
            }
        }

        public static void ReadTextFromFileCustom(string path)
        {
            using (OurReader or = new OurReader(path))
            {
                Console.WriteLine(or.ReadAllFile());
            }
        }

        public static void OurDisposableExample()
        {
            try
            {
                Console.WriteLine("Enter text pt1:");
                string text1 = Console.ReadLine();
                AppendTextInFileCustom(text1, FilePath);

                Console.WriteLine("Enter text pt2:");
                string text2 = Console.ReadLine();
                AppendTextInFileCustom(text2, FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
            Console.WriteLine("-------- Read ---------");
            ReadTextFromFileCustom(FilePath);
        }


        #endregion


        static void Main(string[] args)
        {
            CreateFolder(FolderPath);
            CreateFile(FilePath);

            //ManualExample();
            //UsingExample();
            OurDisposableExample();

            Console.ReadLine();
        }
    }
}
