using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IPerson
    {
        //string Nationality { get; set; } //getter, setter, because they are methods
        string GetInfo();
        void Greet(string name);
        void Goodbye();
    }
}
