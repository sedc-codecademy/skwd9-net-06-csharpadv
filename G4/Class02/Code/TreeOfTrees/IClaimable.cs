using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfTrees
{
    public interface IClaimable
    {
        double Height { get; set; }

        void Climb();
    }
}
