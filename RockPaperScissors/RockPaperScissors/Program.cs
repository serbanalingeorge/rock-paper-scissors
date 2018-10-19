using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;

            Player player = new Player();
            Console.WriteLine("Type your first name: ");
            player.firstName = Console.ReadLine();
            Console.WriteLine("Type your last name: ");
            player.lastName = Console.ReadLine();
            Player.UserInfo(player.firstName, player.lastName);
            Oponent oponent = new Oponent();

            while (play)
            {
                Console.WriteLine("It's your turn to choose! Type rock, paper or scissors!");

                string userSelection = Console.ReadLine();
                string oponentSelection = oponent.ComputerChoice();

                Console.WriteLine("The computer chose {0}.", oponentSelection);
                Console.WriteLine(oponent.Result(userSelection, oponentSelection));

                Console.WriteLine("Play Again? y/n");
                
                string play_again = Console.ReadLine();
                if (play_again == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    play = false;
                }
                else
                {
                    Console.WriteLine("Press ENTER to start the game again!");
                }
                
                Console.ReadLine();
            }
        }
    }

    public class Player
    {
        public string firstName { get; set; }
        public string lastName { get; set; }



        public static void UserInfo(string firstName, string lastName)
        {
            Console.WriteLine("Welcome, {0} {1} to rock-paper-scissor game!", firstName, lastName);
            Console.WriteLine("Press ENTER to start the game!");
            Console.ReadLine();

        }

    }

    public class Oponent
    {
        public string ComputerChoice()
        {
            string[] choices = new string[] {"rock", "paper", "scissors"};
            Random rnd = new Random();
            int index = rnd.Next(0, choices.Length);
            return choices[index];
        }

        public string Result(string choice1, string choice2)
        {
            Dictionary<string, string> rules = new Dictionary<string, string>();
            rules.Add("rock", "scissors");
            rules.Add("paper", "rock");
            rules.Add("scissors", "paper");

            if (!rules.ContainsKey(choice1))
            {
                return "You didn't make a sensible choice!";
            }
            else if (rules[choice1] == choice2)
            {
                return "You win!";
            }
            else if (rules[choice2] == choice1)
            {
                return "You lose!";
            }
            else
            {
                return "A draw!";
            }

        }
    }
}
