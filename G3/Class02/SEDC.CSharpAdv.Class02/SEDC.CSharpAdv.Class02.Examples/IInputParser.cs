using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Examples
{
    public interface IInputParser
    {
        int ToInt(int min, int max);
    }
}
