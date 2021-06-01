using System;
using System.IO;

namespace DisposingDemo
{
    public class CustomLogger : ICustomLogger
    {
        private string _path;
        private StreamWriter _sw;

        public CustomLogger(string path)
        {
            _path = path;
            _sw = new StreamWriter(path, true);
        }

        public void LogError(string message)
        {
            _sw.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss} [ERR] {message}");
        }

        public void LogInfo(string message)
        {
            _sw.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss} [INF] {message}");
        }

        public void Dispose()
        {
            _path = string.Empty;

            _sw.Dispose();
        }
    }
}
