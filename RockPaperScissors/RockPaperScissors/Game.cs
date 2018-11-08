using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RockPaperScissors.Enums;
using RockPaperScissors.StrategyPattern;
using RockPaperScissors.Web;

namespace RockPaperScissors
{
    public class Game
    {
        Player player1 = new Player();
        Player player2 = new Player();
        Rule rule = new Rule();


        public void DisplayGame()
        {
            Console.WriteLine("Welcome to Rock : Paper : Scissors Game!");
        }
        public void DisplayMatrix()
        {
            Console.WriteLine("                                  P 2/C 2" +
                              "\n                    |Rock(1)| Paper(2)| Scissors(3)|" +
                              "\n  P/C    Rock(1)    |  0    |   -1    |      1     |" +
                              "\n  1/1    Paper(2)   |  1    |    0    |     -1     |" +
                              "\n         Scissors(3)| -1    |    1    |      0     |");
        }

        public void PlayerChooseGame()
        {
            
            Console.WriteLine("Type:" +
                              " \n(1) for playing against computer," +
                              " \n(2) for playing against other player," +
                              " \n(3) for playing computer against computer!");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    PlayerAgainstComputer();
                    break;
                case "2":
                    PlayerAgainstPlayer();
                    break;
                case "3":
                    ComputerAgainstComputer();
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
            Console.WriteLine("\nDo you want to play again? y/n");
            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.Clear();
                PlayerChooseGame();
            }
            else if(input == "n")
            {
                Console.WriteLine("See you next time!");
            }
            else
            {
                Console.Clear();
                PlayerChooseGame();
            }
        }

        public void ComputerAgainstComputer()
        {
            player1.SetWeapon(new RandomStrategy());
            player2.SetWeapon(new RandomStrategy());
            int val1 =(int) player1.Attack();
            Console.WriteLine("\n");
            int val2 =(int) player2.Attack();
            Console.WriteLine("\n\nRESULT: {0} " +
                              "\n -1 \t(Computer 1 LOST) " +
                              "\n  1 \t(Computer 1 WON) " +
                              "\n  0 \t(It is a DRAW)",
                rule.DecideWinner(val1, val2));
            DisplayMatrix();
        }

        public void PlayerAgainstComputer()
        {
            int val1 = player2.PlayerStartGame();
            player1.SetWeapon(new RandomStrategy());
            /*Console.WriteLine("\n");*/
            int val2 = (int)player1.Attack();
            Console.WriteLine("\n\nRESULT: {0} " +
                              "\n -1 \t(Player LOST) " +
                              "\n  1 \t(Player WON) " +
                              "\n  0 \t(It is a DRAW) " +
                              "\n -2 \t(Invalid Entries)",
                rule.DecideWinner(val1, val2));
            DisplayMatrix();
        }

        public void PlayerAgainstPlayer()
        {
            Console.WriteLine("First player's turn:");
            int val1 = player1.PlayerStartGame();
            Console.Clear();
            Console.WriteLine("Second player's turn:");
            int val2 = player2.PlayerStartGame();
            Console.Clear();
            Console.WriteLine("\n\nRESULT: {0} " +
                              "\n -1 \t(Player 1 LOST) " +
                              "\n  1 \t(Player 1 WON) " +
                              "\n  0 \t(It is a DRAW) " +
                              "\n -2 \t(Invalid Entries)",
                rule.DecideWinner(val1, val2));
            DisplayMatrix();
        }

        public string NavigateToMainPage()
        {
            
            using (var driver = WebDriver.CreateFor(Driver.Chrome))
            {
                driver.Navigate().GoToUrl("https://www.instructables.com/id/How-to-Play-Rock-Paper-Scissors-Lizard-Spock/");
                string rock = driver.FindElement(By.CssSelector("#step1 > h2")).Text;
                string paper = driver.FindElement(By.CssSelector("#step2 > h2")).Text;
                string scissors = driver.FindElement(By.CssSelector("#step3 > h2")).Text;
                string lizard = driver.FindElement(By.CssSelector("#step4 > h2")).Text;
                string spock = driver.FindElement(By.CssSelector("#step5 > h2")).Text;

                List<string> weapons = new List<string>();
                weapons.Add(rock);
                weapons.Add(paper);
                weapons.Add(scissors);
                weapons.Add(lizard);
                weapons.Add(spock);

                foreach (string weapon in weapons)
                {
                    Console.WriteLine(weapon);
                }
                return null;
            }
        }
    }
}
