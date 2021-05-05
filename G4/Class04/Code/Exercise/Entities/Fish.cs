using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public override void PrintInfo()
        {
            switch (Size)
            {
                case "xs":
                    Console.WriteLine("Where's the fish?!?");
                    break;
                case "s":
                    Console.WriteLine("Oh, here it is");
                    break;
                case "xxl":
                    Console.WriteLine("It gonna eat ya!");
                    break;
                default:
                    break;
            }
        }
    }
}
