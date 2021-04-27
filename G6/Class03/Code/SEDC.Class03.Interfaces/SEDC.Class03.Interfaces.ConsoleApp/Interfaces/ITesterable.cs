using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class03.Interfaces.ConsoleApp.Interfaces
{
    public interface ITesterable
    {
        public int BugsFound { get; set; }
        void TestCode();
    }
}
