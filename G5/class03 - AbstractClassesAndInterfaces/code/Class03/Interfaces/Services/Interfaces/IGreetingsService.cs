using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services.Interfaces
{
    public interface IGreetingsService
    {
        void SayHello(string name);
        void SayGoodBye(string name);
        string ReturnName(string name);
    }
}
