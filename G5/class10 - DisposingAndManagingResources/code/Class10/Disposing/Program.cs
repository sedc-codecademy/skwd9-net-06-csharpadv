using System;
using System.IO;

namespace Disposing
{
    class Program
    {
        public static string AppPath = @"..\..\..\Text";
        public static string FilePath = AppPath + @"\text.txt";

		static void Main(string[] args)
		{
			CreateFolder(AppPath);
			CreateFile(FilePath);


			//ManualExample();

			// Automaited dispose
			UsingExample();
		}

		public static void CreateFolder(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}

		public static void CreateFile(string path)
		{
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
		}

		// Manual example code
		public static void ManualExample() 
		{
			Console.WriteLine("-----WRITE-----");

			string text1 = "Some random text 1";
			AppendTextInFile(text1, FilePath);

			string text2 = "Some random text 2";
			AppendTextInFile(text2, FilePath);

			string text3 = "Some random text 3";
			AppendTextInFile(text3, FilePath);


			Console.WriteLine("-----READ-----");
			ReadTextFromFile(FilePath);


            try
            {
				string text4 = "break";
				AppendTextInFile(text4, FilePath);
			}
            catch (Exception ex)
            {
				Console.WriteLine(ex.Message);
            }
		}

		public static void AppendTextInFile(string text, string path) 
		{
			StreamWriter sw = new StreamWriter(path, true);

			if (text == "break") 
			{
				throw new Exception("Someting is wrong!");
			}

			sw.WriteLine(text);
			sw.Dispose();
		}

		public static void ReadTextFromFile(string path) 
		{
			StreamReader sr = new StreamReader(path);
			Console.WriteLine(sr.ReadToEnd());

			sr.Dispose();
		}

		// Using example code
		public static void UsingExample() 
		{

			Console.WriteLine("-----WRITE-----");

			string text1 = "Some random text 1";
			AppendTextInFile(text1, FilePath);

			string text2 = "Some random text 2";
			AppendTextInFile(text2, FilePath);

			string text3 = "Some random text 3";
			AppendTextInFile(text3, FilePath);


			Console.WriteLine("-----READ-----");
			ReadTextFromFile(FilePath);

		}

		public static void AppendTextInFileSafe(string text, string path)
		{
			using (StreamWriter sw = new StreamWriter(path, true)) 
			{
				if (text == "break")
				{
					throw new Exception("Someting is wrong!");
				}

				sw.WriteLine(text);
			}
		}

		public static void ReadTextFromFileSafe(string path)
		{
			using (StreamReader sr = new StreamReader(path)) 
			{
				Console.WriteLine(sr.ReadToEnd());
			}		
		}

	}
}
