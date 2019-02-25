using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RockPaperScissors.Enums;
using RockPaperScissors.GameRules;
using RockPaperScissors.StrategyPattern;
using RockPaperScissors.StrategyPattern.Context;
using RockPaperScissors.StrategyPattern.Strategies;
using RockPaperScissors.Web;

namespace RockPaperScissors
{
    public class Game
    {
        private readonly Player player1 = new Player();
        private readonly Player player2 = new Player();
        private readonly Rule rule = new Rule();

        public void ShowResult(int value1, int value2)
        {
            rule.Winner(value1, value2);
            //DisplayMessage.Result();
        }

        public void DisplayGame()
        {
            DisplayMessage.Welcome();
        }
        public void DisplayMatrix()
        {
            //DisplayMessage.Matrix();
        }

        public void ChooseGame()
        {
            while (true)
            {
                DisplayMessage.Games();

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayMessage.ClearConsole();
                        PlayerAgainstComputer();
                        break;
                    case "2":
                        DisplayMessage.ClearConsole();
                        PlayerAgainstPlayer();
                        break;
                    case "3":
                        DisplayMessage.ClearConsole();
                        ComputerAgainstComputer();
                        break;
                    default:
                        DisplayMessage.NotValid();
                        break;
                }

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
                        DisplayMessage.EndGame();
                        break;
                    default:
                        Console.Clear();
                        continue;
                }

                break;
            }
        }

        public void ComputerAgainstComputer()
        {
            player1.SetWeapon(new RandomStrategy());
            player2.SetWeapon(new RandomStrategy());
            var val1 =(int) player1.Attack();
            DisplayMessage.NewLine();
            var val2 =(int) player2.Attack();
            DisplayMessage.NewLine();
            ShowResult(val1,val2);
            DisplayMatrix();
        }

        public void PlayerAgainstComputer()
        {
            var val1 = player2.Play();
            player1.SetWeapon(new RandomStrategy());
            /*Console.WriteLine("\n");*/
            var val2 = (int)player1.Attack();
            DisplayMessage.NewLine();
            ShowResult(val1,val2);
            DisplayMatrix();
        }

        public void PlayerAgainstPlayer()
        {
            DisplayMessage.FirstPlayerTurn();
            var val1 = player1.Play();
            Console.Clear();
            DisplayMessage.SecondPlayerTurn();
            var val2 = player2.Play();
            Console.Clear();
            ShowResult(val1,val2);
            DisplayMatrix();
        }

    }
}
