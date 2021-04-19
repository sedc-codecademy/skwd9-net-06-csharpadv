﻿using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int draws = 0;
            int userWins = 0;
            int computerWins = 0;
            //int userWins = 0, computerWins = 0, draws = 0;

            while (true)
            {
                try
                {
                    OptionEnum userSelection = SelectOption();
                    OptionEnum computerSelection = ComputerOption();

                    ResultEnum result = DecideWinner(userSelection, computerSelection);

                    switch (result)
                    {
                        case ResultEnum.PlayerWins:
                            userWins++;
                            break;
                        case ResultEnum.ComputerWins:
                            computerWins++;
                            break;
                        case ResultEnum.Draw:
                            draws++;
                            break;
                        default:
                            throw new Exception("Invalid outcome");
                    }

                    int playedGames = userWins + draws + computerWins;

                    Console.WriteLine($"===={userSelection}=====||====={computerSelection}====");
                    Console.WriteLine($"========{result}========");
                    Console.WriteLine($"{"Player",10}|{"Wins",6}|{"%",6}");

                    //Console.WriteLine($"{"User",10}|{userWins,6}|{$"{CalculatePercentage(userWins, playedGames).ToString("P")}",6}");
                    Console.WriteLine($"{"User",10}|{userWins,6}|{$"{CalculatePercentage(userWins, playedGames):P}",6}");
                    Console.WriteLine($"{"Computer",10}|{computerWins,6}|{$"{CalculatePercentage(computerWins, playedGames):P}",6}");
                    Console.WriteLine($"{"Draw",10}|{draws,6}|{$"{CalculatePercentage(draws, playedGames):P}",6}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static OptionEnum SelectOption()
        {
            Console.WriteLine("Please select an option");
            Console.WriteLine($"{(int)OptionEnum.Rock}. {OptionEnum.Rock}");
            Console.WriteLine($"{(int)OptionEnum.Paper}. {OptionEnum.Paper}");
            Console.WriteLine($"{(int)OptionEnum.Scissors}. {OptionEnum.Scissors}");
            string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "1":
            //        return OptionEnum.Rock;
            //    case "2":
            //        return OptionEnum.Paper;
            //    case "3":
            //        return OptionEnum.Scissors;
            //    default:
            //        throw new Exception("Invalid input for select option");
            //}

            bool successParse = int.TryParse(input, out int option);

            if (!successParse)
            {
                throw new Exception("Invalid input for select option");
            }

            if (option < 1 || option > 3)
            {
                throw new Exception("Invalid input for select option");
            }

            return (OptionEnum) option;
        }

        static OptionEnum ComputerOption()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);

            return (OptionEnum) randomNumber;
        }

        static ResultEnum DecideWinner(OptionEnum userSelection, OptionEnum computerSelection)
        {
            #region StepByStep control

            //if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Scissors)
            //{
            //    return ResultEnum.PlayerWins;
            //}

            //if (userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Rock)
            //{
            //    return ResultEnum.PlayerWins;
            //}

            //if (userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Paper)
            //{
            //    return ResultEnum.PlayerWins;
            //}

            //if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Paper)
            //{
            //    return ResultEnum.ComputerWins;
            //}

            //if (userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Scissors)
            //{
            //    return ResultEnum.ComputerWins;
            //}

            //if (userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Rock)
            //{
            //    return ResultEnum.ComputerWins;
            //}

            //if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Rock)
            //{
            //    return ResultEnum.Draw;
            //}

            //if (userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Paper)
            //{
            //    return ResultEnum.Draw;
            //}

            //if (userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Scissors)
            //{
            //    return ResultEnum.Draw;
            //}

            //throw new Exception("Invalid scenario");



            #endregion


            #region Optimal solution with all win cases
            //if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Scissors ||
            //    userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Rock ||
            //    userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Paper)
            //{
            //    return ResultEnum.PlayerWins;
            //}

            //if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Paper ||
            //    userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Scissors ||
            //    userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Rock)
            //{
            //    return ResultEnum.ComputerWins;
            //}

            //return ResultEnum.Draw;
            #endregion


            if (userSelection == OptionEnum.Rock && computerSelection == OptionEnum.Scissors ||
                userSelection == OptionEnum.Paper && computerSelection == OptionEnum.Rock ||
                userSelection == OptionEnum.Scissors && computerSelection == OptionEnum.Paper)
            {
                return ResultEnum.PlayerWins;
            }

            //if (userSelection == computerSelection)
            //{
            //    return ResultEnum.Draw;
            //}

            //return ResultEnum.ComputerWins;
            return userSelection == computerSelection ? ResultEnum.Draw : ResultEnum.ComputerWins;
        }

        static decimal CalculatePercentage(int wins, int total)
        {
            return (wins / (decimal) total);
        }
    }
}
