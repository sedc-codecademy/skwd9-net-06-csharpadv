using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingLibrary
{
    public delegate void PunchThrow(int punchValue);
    public delegate void HitOrMiss(HitType isHit);
    public delegate void PointsPunch(int points);
}
