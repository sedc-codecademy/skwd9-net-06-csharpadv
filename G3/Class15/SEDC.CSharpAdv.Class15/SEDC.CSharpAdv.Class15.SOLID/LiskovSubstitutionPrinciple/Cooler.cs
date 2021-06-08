using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class15.SOLID.LiskovSubstitutionPrinciple
{
    public class Cooler : ISwitch
    {
        public void Off()
        {
        }

        public void On()
        {
        }

        public void Regulate()
        {
            Console.WriteLine("Im Cooler");
        }
    }

    public class Fan : ISwitch
    {
        public void Off()
        {
        }

        public void On()
        {
        }

        public void Regulate()
        {
            Console.WriteLine("Im Fan");
        }
    }
}
