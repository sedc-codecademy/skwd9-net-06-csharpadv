using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void SayHello(string name);
        void SayGoodBye(string name);
    }
}
