using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.Interfaces.ConsoleApp.Interfaces
{
    public interface IDevops
    {
        public bool IsAWSCertified { get; set; }
        public bool IsAzureCertified { get; set; }
        string CheckHTTPRequest(int statusCode);
    }
}
