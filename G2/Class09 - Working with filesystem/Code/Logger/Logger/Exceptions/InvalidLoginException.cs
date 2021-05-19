using Logger.Services;
using System;

namespace Logger.Exceptions
{
    public class InvalidLoginException : Exception
    {
        private LoggerService _loggerService;
        public InvalidLoginException(string username) : base($"Invalid login for {username}") //Message property
        {
            _loggerService = new LoggerService();
            _loggerService.LogErrorCount();
        }
    }
}
