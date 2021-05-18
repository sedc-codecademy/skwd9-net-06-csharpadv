using System;
using System.IO;

namespace Logger.Services
{
    public class LoggerService
    {
        private string _folderPath;
        private string _errorCountPath;
        private string _logsPath;

        public LoggerService()
        {
            _folderPath = @"..\..\..\logs";
            _errorCountPath = _folderPath + @"\errorCount.txt";
            _logsPath = _folderPath + @"\logs.txt";
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        public void Log(string error, string message, string userName = "Unknown")
        {
            using(StreamWriter sw = new StreamWriter(_logsPath, true))
            {
                sw.WriteLine($"[Error]: {error}");
                sw.WriteLine($"Message: {message}");
                sw.WriteLine($"Time: {DateTime.Now}");
                sw.WriteLine($"User: {userName}");
                sw.WriteLine("======================");
            }
        }

        public void LogErrorCount()
        {
            if (!File.Exists(_errorCountPath))
            {
                File.Create(_errorCountPath).Close();
            }
            int count = 0;
            
            using(StreamReader sr = new StreamReader(_errorCountPath))
            {
                bool success = int.TryParse(sr.ReadLine(), out count);
            }
            using(StreamWriter sw = new StreamWriter(_errorCountPath))
            {
                sw.WriteLine(count + 1);
            }
        }
    }
}
