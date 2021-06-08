using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingLibrary
{
    public class Play
    {
        public event PunchThrow PunchCh;
        public event HitOrMiss HitMiss;
        public event PointsPunch PointsPunch;
        public int NumPunches { get; set; }
        public HitType IsHit { get; set; }
        public void Game<T>(T playerOne, T playerTwo, int times, Display display) where T : Boxer
        {
            Add(playerOne.SetType);
            Add(playerTwo.SetType);
            PunchCh += display.setType;
            AddHitMiss(display.Hit);
            AddPointsPunch(display.PunchValue);
            int go = 1;
            int whenBreak = 0;
            bool playGame = true;
            while (playGame)
            {
                if (whenBreak == times)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wiiner is {0}.", WhoIsWiiner(playerOne, playerOne));
                    break; 
                }
                Random rnd = new Random();
                int myRandom = rnd.Next(0, 4);

                PunchCh(myRandom);

                if(go == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    int pointsAg = playerTwo.PointsAgility(playerOne.PointsStrength());
                    if (pointsAg > 0)
                    {
                        IsHit = HitType.hit;
                        HitMiss(IsHit);
                        PointsPunch(pointsAg);
                        playerTwo.Hitpoints = playerTwo.Hitpoints - pointsAg;
                        display.Print(playerOne, playerTwo);
                        
                        if (playerTwo.Hitpoints <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wiiner is {0}.", WhoIsWiiner(playerOne, playerOne));
                            break;
                        }
                    }
                    else
                    {
                        IsHit = HitType.miss;
                        HitMiss(IsHit);
                        display.Print(playerOne, playerTwo);
                    }
                    whenBreak++;
                    go = 2;
                }
                if(go == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int pointsAg = playerOne.PointsAgility(playerTwo.PointsStrength());
                    //if (playerTwo.PointsStrength() - pointsAg > 0)
                    if (pointsAg > 0)
                    {
                        IsHit = HitType.hit;
                        HitMiss(IsHit);
                        PointsPunch(pointsAg);
                        playerOne.Hitpoints = playerOne.Hitpoints - pointsAg;
                        display.Print(playerTwo, playerOne); 

                        if (playerOne.Hitpoints <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Winner is {0}.", WhoIsWiiner(playerOne, playerOne));
                            break;
                        }
                    }
                    else
                    {
                        IsHit = HitType.miss;
                        HitMiss(IsHit);
                        display.Print(playerTwo, playerOne);
                    }
                    whenBreak++;
                    go = 1;
                }
            }
        }
        public void Add(PunchThrow punchThrow)
        {
            PunchCh += punchThrow;
        }
        public void AddHitMiss(HitOrMiss hitOrMiss)
        {
            HitMiss += hitOrMiss;
        }
        public void AddPointsPunch(PointsPunch pointsPunch)
        {
            PointsPunch += pointsPunch;
        }
        public string WhoIsWiiner<TOne, TTwo>(TOne playerOne, TTwo playerTwo) where TOne : Boxer where TTwo : Boxer
        {
           if( playerOne.Hitpoints > playerTwo.Hitpoints)
            {
                return playerOne.Name;
            }
            else
            {
                return playerTwo.Name;
            }
        }

    }
}
