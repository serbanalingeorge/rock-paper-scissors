using System;
using RockPaperScissors.Helper;
using RockPaperScissors.StrategyPattern.Games;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Context
{
    public class Game
    {
        public void Play()
        {
            while (true)
            {
                DisplayMessage.Games();

                var userInput = Console.ReadLine();

                StartGame(SelectedGame(userInput));

                DisplayMessage.WantToPlayAgain();
                var input = Console.ReadLine();
                
                switch (input)
                {
                    case "y":
                    case "Y":
                        Console.Clear();
                        continue;
                    case "n":
                    case "N":
                        Console.Clear();
                        DisplayMessage.EndGame();
                        break;
                    default:
                        Console.Clear();
                        continue;
                }

                break;
            }
        }

        private static IGame SelectedGame(string input)
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    return new PlayerVsComputer();
                case "2":
                    Console.Clear();
                    return new PlayerVsPlayer();
                case "3":
                    Console.Clear();
                    return new ComputerVsComputer();
                default:
                    Console.Clear();
                    return new PlayerVsComputer();
            }
        }

        private static void StartGame(IGame game)
        {
            game.Play();
        }
    }
}


