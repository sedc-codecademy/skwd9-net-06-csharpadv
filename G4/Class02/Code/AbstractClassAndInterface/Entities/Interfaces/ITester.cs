using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface.Entities.Interfaces
{
    public interface ITester
    {
        int BugsFound { get; set; }
        void TestFeature(string feature);
    }
}
