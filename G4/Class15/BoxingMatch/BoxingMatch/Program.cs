using BoxingLibrary;
using System;

namespace BoxingMatch
{
    class Program
    {
        private static Play _play = new Play();
        static void Main(string[] args)
        {
            Boxer tysonFury = new Boxer("Tyson Fury", 124, 1000, new PointOfDemage(20, 10, 25, 20), new PointOfDemage(15, 15, 30, 15));
            Boxer andyRuizJr = new Boxer("Andy Ruiz Jr.", 128, 1500, new PointOfDemage(26, 16, 21, 16), new PointOfDemage(26, 26, 16, 21));

            Display display = new Display();
            _play.Game(tysonFury, andyRuizJr, 250, display);  
            Console.ReadLine();
        }
    }
}
