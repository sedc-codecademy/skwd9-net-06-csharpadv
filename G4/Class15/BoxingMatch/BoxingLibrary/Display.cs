using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingLibrary
{
    public class Display
    {
        public int PunchType { get; set; }
        public string PunchT { get; set; }
        public HitType HitT { get; set; }
        public int PointsHint { get; set; }
        protected int PunchVal { get; set; }

        public void setType(int type)
        {
            PunchType = type;
        }
        public void PunchValue(int value)
        {
            PunchVal = value;
        }
        public void TypePunch()
        {
            switch (PunchType)
            {
                case 0: PunchT = "Cross"; break;
                case 1: PunchT = "Jab"; break;
                case 2: PunchT = "Uppercut"; break;
                case 3: PunchT = "Hook"; break;
            }
        }
        public void Hit(HitType isHit)
        {
            HitT = isHit;
        }
        public void Print(Boxer punchingBoxer, Boxer receivingBoxer)
        {
            if (HitT == HitType.hit)
            {
                Console.WriteLine("It's a hit.");
                TypePunch();
                
                Console.WriteLine($"{receivingBoxer.Name} has been hit by {PunchT} for {PunchVal} damage, " +
                    $"and now he has {receivingBoxer.Hitpoints} hitpoints");
                Console.WriteLine($"{punchingBoxer.Hitpoints} : {receivingBoxer.Hitpoints}");
            }
            if(HitT == HitType.miss)
            {
                Console.WriteLine("It's a miss.");
                Console.WriteLine($"{punchingBoxer.Hitpoints} : {receivingBoxer.Hitpoints}");
            }
        }
    }
}
