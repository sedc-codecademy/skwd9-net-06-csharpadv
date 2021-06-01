using System;
using System.IO;

namespace SerializationDemo.Helper
{
    public static class FileHelper
    {
        public static void Write(string path, string data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
        }

        public static string Read(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("Invalid file path");
            }

            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
