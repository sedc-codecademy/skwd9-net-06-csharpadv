using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class14.GettersSetters
{
    public abstract class BaseEntity
    {
        protected string _name;
        public abstract string Name { get; set; }
    }
}
