using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingLibrary
{
    public class PointOfDemage 
    {
        public int Cross;
        public int Jab;
        public int Uppercut;
        public int Hook;
        public PointOfDemage(int cross, int jab, int uppercut, int hook)
        {
            Cross = cross;
            Jab = jab;
            Uppercut = uppercut;
            Hook = hook;
        }
    }
}
