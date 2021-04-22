using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.AbstractInheritance
{
    public class SecondClass : FirstClass
    {
        public override int Id { get; set; }

        public override void DoSomeAdvancedWork()
        {
            throw new NotImplementedException();
        }
    }
}
