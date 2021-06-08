using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class15.SOLID.LiskovSubstitutionPrinciple
{
    public interface ISwitch
    {
        void On();
        void Off();
        void Regulate();
    }
}
