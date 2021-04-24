using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfTrees
{
    public class Mountain : IClaimable
    {
        public string Name { get; set; }

        public double Height { get; set; }

        public Mountain(string name)
        {
            Name = name;
        }

        public void Climb()
        {
            Console.WriteLine($"Climbing mountain {Name}");
        }
    }

    public class WoodyHill : IClaimable, IWooded
    {
        public string Name { get; set; }

        public double Height { get; set; }

        public WoodyHill(string name)
        {
            Name = name;
        }
        public List<Tree> Trees { get; set; }

        public void Climb()
        {
            Console.WriteLine($"Climbing woody hill {Name}");
        }


        public void Deforestation()
        {
            throw new NotImplementedException();
        }

        public void Forestation()
        {
            throw new NotImplementedException();
        }
    }

    public class WoodyMountain : Mountain, IWooded
    {
        public WoodyMountain(string name) : base(name) { }
        public List<Tree> Trees { get; set; }

        public void Deforestation()
        {
            throw new NotImplementedException();
        }

        public void Forestation()
        {
            throw new NotImplementedException();
        }
    }
}
