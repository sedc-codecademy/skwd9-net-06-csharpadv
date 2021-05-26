using System;
using System.IO;

namespace Serialization.Services
{
    public class FileSystemService
    {
        public string ReadFileContent(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception($"The file {path} waas not found!");
            }
            string result = string.Empty;

            using(StreamReader streamReader = new StreamReader(path))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }

        public void WriteInFile(string path, string content)
        {
            using(StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(content);
            }
        }
    }
}
