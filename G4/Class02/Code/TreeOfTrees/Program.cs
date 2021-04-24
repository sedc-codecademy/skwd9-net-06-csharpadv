using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeOfTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new AppleTree();
            var result = myTree.GetSeedsMultiple(3);
            Console.WriteLine(string.Join("\n", result));
            Console.WriteLine("------------");

            var trees = new List<Tree>
            {
                new AppleTree(),
                new PearTree(),
                new BananaTree(),
                new WalnutTree(),
                new EvergreenTree(EvergreenType.Pine)
            };

            var fruits = trees.Select(tree => tree.GetSeeds());
            Console.WriteLine(string.Join("\n", fruits));
            Console.WriteLine("------------");

            var climbables = new List<IClaimable>();

            climbables.Add(new AppleTree());
            climbables.Add(new WoodyHill("Ljubash"));
            climbables.Add(new WoodyMountain("Baba"));

            foreach (var item in climbables)
            {
                //Console.WriteLine(item is Tree);
                //Console.WriteLine(item is Mountain);
                //Console.WriteLine(item is WoodyMountain);
                if (item is Mountain mountain)
                {
                    Console.WriteLine("Is item mountain?");
                    Console.WriteLine(item == mountain);
                    // Console.WriteLine(item.Name);
                    Console.WriteLine(mountain.Name);
                }

                item.Climb();
            }

            Console.ReadLine();
        }
    }
}
