using Logger.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidPropertyException : Exception
    {
        private LoggerService _loggerService;
        public InvalidPropertyException() : base("Some of the properties are invalid.")
        {
            _loggerService = new LoggerService();
            _loggerService.LogErrorCount();
        }

        public InvalidPropertyException(string property, string username) : base($"Invalid property {property} for {username}")
        {
            _loggerService = new LoggerService();
            _loggerService.LogErrorCount();
        }
    }
}
