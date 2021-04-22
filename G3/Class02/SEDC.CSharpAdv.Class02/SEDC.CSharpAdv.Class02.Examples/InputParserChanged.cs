using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Examples
{
    public class InputParserChanged : BaseParser, IInputParser
    {
        public int ToInt(int min, int max)
        {
            return 12300000;
        }
    }
}
