using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.AbstractClassesAndInterfaces.Entities.Interfaces
{
    public interface IDeveloper
    {
        int Id { get; set; }
        void Code();
    }
}
