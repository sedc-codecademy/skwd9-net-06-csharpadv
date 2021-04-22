using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class01.ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player damjan = new Player() { Name = "Damjan" };
            Player petre = new Player() { Name = "Petre" };
            Console.WriteLine("Please enter 1 to play 2 for stats and 3 to exit");
            string userInput = Console.ReadLine();
            int menuChosen = ChooseMenuItem(userInput);
            //if(menuChosen == 0)
            //{
            //    throw new Exception("The user input must be a number and not zero");
            //}
            //else if(menuChosen == 1)
            //{
            //    //TODO: Should play the game
            //}
            //else if(menuChosen == 2)
            //{
            //    //TODO: Should show 
            //}
            //else
            //{
            //    //Exit the applicaiton
            //}
            switch (menuChosen)
            {
                case 0:
                    throw new Exception("Wrong input");
                    break;
                case 1:
                    Play(damjan, petre);
                    break;
                case 2:
                    //Show stats
                    break;
                default:
                    //Close the app
                    break;
            }
            Console.ReadLine();
        }

        static int ChooseMenuItem(string userInput)
        {
            int result = 0;
            bool isValidNumber = int.TryParse(userInput, out result);
            return result;
        }

        static void Play(Player playerOne, Player playerTwo)
        {
            int playerOnePickRandom = new Random().Next(1, 3);
            playerOne.PlayerChoice = (UserChoice)playerOnePickRandom;
            int playerTwoPickRandom = new Random().Next(1, 3);
            playerTwo.PlayerChoice = (UserChoice)playerTwoPickRandom;
            string resultText = DecideWinner(playerOne, playerTwo);
            Console.WriteLine(resultText);
        }

        static string DecideWinner(Player playerOne, Player playerTwo)
        {
            if(playerOne.PlayerChoice == UserChoice.Rock && playerTwo.PlayerChoice == UserChoice.Scissors)
            {
                playerOne.Score++;
                return $"Player {playerOne.Name} won";
            }
            else if (playerOne.PlayerChoice == UserChoice.Rock && playerTwo.PlayerChoice == UserChoice.Paper)
            {
                playerTwo.Score++;
                return $"Player {playerTwo.Name} won";
            }
            else if (playerOne.PlayerChoice == UserChoice.Scissors && playerTwo.PlayerChoice == UserChoice.Paper)
            {
                playerOne.Score++;
                return $"Player {playerOne.Name} won";
            }
            else if (playerOne.PlayerChoice == UserChoice.Scissors && playerTwo.PlayerChoice == UserChoice.Rock)
            {
                playerTwo.Score++;
                return $"Player {playerTwo.Name} won";
            }
            else if (playerOne.PlayerChoice == UserChoice.Paper && playerTwo.PlayerChoice == UserChoice.Scissors)
            {
                playerTwo.Score++;
                return $"Player {playerTwo.Name} won";
            }
            else if (playerOne.PlayerChoice == UserChoice.Paper && playerTwo.PlayerChoice == UserChoice.Rock)
            {
                playerOne.Score++;
                return $"Player {playerOne.Name} won";
            }
            else
            {
                return "It's tie";
            }
        }

        static void DisplayStats(Player player, Player player2, int matchesPlayed)
        {

        }

        static void LeadershipBoard(List<Player> players)
        {
            
        }
    }
}
