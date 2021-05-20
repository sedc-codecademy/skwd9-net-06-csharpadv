using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SDEC.CSharpAdv.Class09.FileStreams.Logger
{
    public class LoggerService : ILogerService
    {
        private string _directoryPath = @"..\..\..\logs\";
        private string _usageLog = "application-usage.txt";
        private string _errorLog = "error-log.txt";

        public LoggerService()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            CreateLogs(_directoryPath + _usageLog);
            CreateLogs(_directoryPath + _errorLog);
        }

        public void LogError(string error, string message, string username)
        {
            string date = DateTime.Now.ToString("HH:mm:ss dd-MM-yyyy");

            using (StreamWriter sw = new StreamWriter(_directoryPath + _errorLog))
            {
                sw.WriteLine($"[ERROR] {date} : {username} : {message} : {error}");
            }
        }

        public void LogUsage(string username, bool isLogedIn)
        {
            string date = DateTime.Now.ToString("HH:mm:ss dd-MM-yyyy");
            
            using (StreamWriter sw = new StreamWriter(_directoryPath + _usageLog, true))
            {
                if (isLogedIn)
                {
                    sw.WriteLine($"[LOGED OUT] {date} [USER] {username}");
                }
                else
                {
                    sw.WriteLine($"[LOGED IN] {date} [USER] {username}");
                }
            }
        }

        private void CreateLogs(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
    }
}
