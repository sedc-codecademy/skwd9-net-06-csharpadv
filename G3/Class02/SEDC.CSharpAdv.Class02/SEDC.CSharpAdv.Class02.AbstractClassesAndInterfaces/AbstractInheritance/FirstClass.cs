using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.AbstractInheritance
{
    public abstract class FirstClass : BaseClass
    {
        public DateTime StartedOn { get; set; }

        public abstract void DoSomeAdvancedWork();

        public override void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
