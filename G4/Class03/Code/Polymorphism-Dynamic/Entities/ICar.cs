using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Dynamic.Entities
{
    public interface ICar
    {
        string MotorNumber { get; set; }

        void Refuel();
    }
}
