using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.AbstractInheritance
{
    public abstract class BaseClass
    {
        public int Id { get; set; }

        public abstract void DoWork();
    }
}
