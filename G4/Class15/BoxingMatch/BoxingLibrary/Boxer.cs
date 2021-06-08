using System;

namespace BoxingLibrary
{
    public class Boxer
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Hitpoints { get; set; }
        protected int punchType { get; set; }
        public PointOfDemage Strength { get; set; } 
        public PointOfDemage Agility { get; set; } 
        public Boxer() { }
        public Boxer(string name, int weight, int hitpoints, PointOfDemage str, PointOfDemage agi)
        {
            Name = name;
            Weight = weight;
            Hitpoints = hitpoints;
            //punchType = punchT; // ne potreben 
            Strength = str;
            Agility = agi;
        }
        public void SetType(int type)
        {
            punchType = type;
        }
        //public abstract int PointsStrength();
        public int PointsStrength()
        {
            switch (punchType)
            {
                case 0: return Strength.Cross; 
                case 1: return Strength.Jab;
                case 2: return Strength.Uppercut;
                case 3: return Strength.Hook;
                default: return 0;
            }
        }
        public int PointsAgility(int points)
        {
            Random rnd = new Random();
            switch (punchType)
            {
                
                case 0:
                    int num0 = rnd.Next(0, Agility.Cross);
                    return points - num0;
                case 1:
                    int num1 = rnd.Next(0, Agility.Jab);
                    return points - num1;
                case 2:
                    int num2 = rnd.Next(0, Agility.Uppercut);
                    return points - num2; 
                case 3:
                    int num3 = rnd.Next(0, Agility.Hook);
                    return points - num3; 
                default: return 0; 
            }
        }

    }
    public enum PunchType
    {
        punchingBoxer,
        recaivingBoxer
    }
}
