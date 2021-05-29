using System;

namespace DisposingDemo
{
    public interface ICustomLogger : IDisposable
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
