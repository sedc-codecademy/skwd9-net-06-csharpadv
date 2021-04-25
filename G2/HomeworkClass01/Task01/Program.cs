using System;
using Task01.Entities;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new RockScissorsPaper();
            game.InitGame();

            Console.ReadLine();
        }
    }
}
