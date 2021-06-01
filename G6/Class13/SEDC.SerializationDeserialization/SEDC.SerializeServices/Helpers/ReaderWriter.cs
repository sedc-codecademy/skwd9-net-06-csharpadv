using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.SerializeServices.Helpers
{
    public static class ReaderWriter
    {
        public static string ReadFile(string path)
        {
            string result = string.Empty;

            if (!File.Exists(path))
            {
                return "The file does not exist!";
            }
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("Successfully read a file!");
            return result;
        }

        public static void WriteFile(string path, string data)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Data successfully written in a file!");
        }
    }
}
