using System;
using System.Collections.Generic;
using System.Text;

namespace Task01.Entities
{
    public class RockScissorsPaper : Game
    {
        private Random _rand = new Random();

        public Player Player { get; set; }
        private Player Cpu { get; set; }

        public RockScissorsPaper()
        {
            // set default players
            Player = new Player() { Name = "Player One" };
            Cpu = new Player() { Name = "Cpu" };
            IsActive = false;
        }

        public void InitGame()
        {
            Console.WriteLine("ROCK PAPER SCISSORS");
            Console.WriteLine("Lets Play");

            while (true)
            {
                Console.WriteLine("1) Start Round \n2) View Stats \n3) Quit");
                var isValidInput = int.TryParse(Console.ReadLine(), out int selection);

                if (!isValidInput)
                {
                    Console.WriteLine("Not valid input. Please select one of the given menu options.");
                    continue;
                }

                switch (selection)
                {
                    case 1:
                        StartGame();
                        break;
                    case 2:
                        PlayerStats();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for playing Rock Scissors Paper. Have a nice day.");
                        break;
                    default:
                        Console.WriteLine("Invalid menu selection");
                        break;
                }
            }
        }

        private void StartGame()
        {
            IsActive = true;
            // gameplay goes here
            while (IsActive)
            {
                Console.WriteLine("1) Start round \n2) End round");
                var isValidInput = int.TryParse(Console.ReadLine(), out int selection);

                if (!isValidInput)
                {
                    Console.WriteLine("Not valid input. Please select one of the given menu options.");
                    continue;
                }

                switch (selection)
                {
                    case 1:
                        PlayRound();
                        break;
                    case 2:
                        IsActive = !IsActive;
                        break;
                    default:
                        Console.WriteLine("Invalid menu selection");
                        break;
                }
            }
        }

        private void PlayerStats()
        {
            Console.WriteLine($"{Player.Name} stats");
            Console.WriteLine($"Won: {Player.Won} Lost: {Player.Lost} Draw: {Player.Draw} Win%: {CalculateWinPercent(GetGamesPlayed(), Player.Won)}");

            Console.WriteLine($"{Cpu.Name} stats");
            Console.WriteLine($"Won: {Cpu.Won} Lost: {Cpu.Lost} Draw: {Cpu.Draw} Win%: {CalculateWinPercent(GetGamesPlayed(), Cpu.Won)}");
        }

        private void PlayRound()
        {
            Console.WriteLine("1) Rock \n2) Paper \n3) Scissors");
            var isValidInput = int.TryParse(Console.ReadLine(), out int selection);

            if (!isValidInput)
            {
                Console.WriteLine("Not valid input.");
                return;
            }

            var result = RoundResult(selection);
            string winnerName = string.Empty;
            if (result.Winner == 1)
            {
                winnerName = Player.Name;
                Player.Won += 1;
                Cpu.Lost += 1;
            }
            else if (result.Winner == 2)
            {
                winnerName = Cpu.Name;
                Player.Lost += 1;
                Cpu.Won += 1;
            }
            else
            {
                Player.Draw += 1;
                Cpu.Draw += 1;
                Console.WriteLine(result.Message);
            }

            IncreaseGamesPlayed();
            if (!string.IsNullOrEmpty(winnerName))
            {
                Console.WriteLine($"{result.Message} \nWinner {winnerName} in round {GetGamesPlayed()}");
            }
        }

        private RoundResult RoundResult(int playedSelection)
        {
            var response = new RoundResult();
            var cpuPlay = _rand.Next(1, 4);

            if (playedSelection == cpuPlay)
            {
                response.Winner = 0;
                response.Message = "It is a draw";
                return response;
            }

            switch (cpuPlay)
            {
                case 1:
                    if (playedSelection == 2)
                    {
                        response.Winner = 2;
                        response.Message = "Rock crushes scissors or somethimes blunts them.";
                    }
                    else if (playedSelection == 3)
                    {
                        response.Winner = 1;
                        response.Message = "Paper covers rock.";
                    }
                    break;
                case 2:
                    if (playedSelection == 1)
                    {
                        response.Winner = 2;
                        response.Message = "Paper covers rock.";
                    }
                    else if (playedSelection == 3)
                    {
                        response.Winner = 1;
                        response.Message = "Scissors cut paper";
                    }
                    break;
                case 3:
                    if (playedSelection == 1)
                    {
                        response.Winner = 1;
                        response.Message = "Rock crushes scissors or somethimes blunts them.";
                    }
                    else if (playedSelection == 2)
                    {
                        response.Winner = 2;
                        response.Message = "Scissors cut paper";
                    }
                    break;
            }
            return response;
        }

        private double CalculateWinPercent(int played, int won)
        {
            try
            {
                return (played / won) * 100;
            }
            catch (DivideByZeroException)
            {
                // handle error
            }
            return 0;
        }
    }
}
