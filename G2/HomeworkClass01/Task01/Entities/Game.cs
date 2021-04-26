using System;
using System.Collections.Generic;
using System.Text;

namespace Task01.Entities
{
    public class Game
    {
        private int _gamesPlayed { get; set; }
        protected bool IsActive { get; set; }

        public Game()
        {
            _gamesPlayed = 0;
        }

        protected void IncreaseGamesPlayed()
        {
            _gamesPlayed += 1;
        }

        protected int GetGamesPlayed()
        {
            return _gamesPlayed;
        }
    }
}
