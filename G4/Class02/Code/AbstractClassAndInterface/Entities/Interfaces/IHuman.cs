using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAndInterface.Entities.Interfaces
{
    public interface IHuman
    {
        // we only put the signature without access modifier
        string GetInfo();

        void Greet(string name);
    }
}
