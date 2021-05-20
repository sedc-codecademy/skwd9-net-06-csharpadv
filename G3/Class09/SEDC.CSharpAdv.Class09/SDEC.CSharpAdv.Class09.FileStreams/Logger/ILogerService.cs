using System;
using System.Collections.Generic;
using System.Text;

namespace SDEC.CSharpAdv.Class09.FileStreams.Logger
{
    public interface ILogerService
    {
        void LogUsage(string username, bool isLogedIn);
        void LogError(string error, string message, string username);
    }
}
