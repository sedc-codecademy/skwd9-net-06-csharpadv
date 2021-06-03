using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class14.GettersSetters
{
    public class Subject : BaseEntity
    {
        //public override int Name { get; set; }
        public override string Name { get { return _name.ToUpper(); } set { _name = value; } }

    }
}
