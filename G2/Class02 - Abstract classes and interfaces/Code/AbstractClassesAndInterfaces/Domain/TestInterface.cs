using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class TestInterface : IPerson
    {
        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        public void Goodbye()
        {
            throw new NotImplementedException();
        }

        public void Greet(string name)
        {
            throw new NotImplementedException();
        }
    }
}
