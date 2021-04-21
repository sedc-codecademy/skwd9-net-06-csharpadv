using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfTrees
{
    public abstract class Tree : IClaimable
    {
        public string Trunk { get; set; }
        public string Root { get; set; }
        public List<string> Branches { get; set; }
        public double Height { get; set; }

        public void Climb()
        {
            Console.WriteLine("Climbing tree");
        }

        public abstract string GetSeeds();

        public List<string> GetSeedsMultiple(int times)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < times; i++)
            {
                result.Add(GetSeeds());
            }
            return result;
        }
    }

    public enum EvergreenType
    {
        Pine,
        Juniper
    }
    public class EvergreenTree : Tree
    {
        public EvergreenType Type { get; private set; }
        public EvergreenTree(EvergreenType type)
        {
            Type = type;
        }

        public override string GetSeeds()
        {
            Console.WriteLine("Making like a evergreen");
            return Type switch
            {
                EvergreenType.Pine => "Pinecone",
                EvergreenType.Juniper => "Juniper cone",
                _ => "Some other evergreen stuff"
            };
        }
    }

    public abstract class FriutTree : Tree
    {
        public string FruitName { get; private set; }
        public FriutTree(string fruitName)
        {
            FruitName = fruitName;
        }
    }

    public class AppleTree : FriutTree
    {
        public AppleTree() : base("Apples")
        {

        }

        public override string GetSeeds()
        {
            Console.WriteLine("Making like an apple tree");
            return FruitName;
        }

    }

    public class PearTree : FriutTree
    {
        public PearTree() : base("Pears")
        {

        }

        public override string GetSeeds()
        {
            Console.WriteLine("Making like an pear tree");
            return FruitName;
        }

    }

    public class BananaTree : FriutTree
    {
        public BananaTree() : base("Bananas")
        {

        }

        public override string GetSeeds()
        {
            Console.WriteLine("Making like an banana tree");
            return FruitName;
        }

    }

    public class WalnutTree : FriutTree
    {
        public WalnutTree() : base("Walnuts")
        {

        }

        public override string GetSeeds()
        {
            Console.WriteLine("Making like an walnut tree");
            return FruitName;
        }

    }


}
