using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.StrategyPattern.Context;

namespace RockPaperScissors.NewGame.Entities
{
    public class Game
    {
        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public GameResult Play()
        {
            Player winner = null;
            var draw = false;

            var player1Wins = Attack(Player1, Player2);
            var player2Wins = Attack(Player2, Player1);

            if (player1Wins && player2Wins)
                throw new NotSupportedException("Cannot have 2 winners");
            if ((player1Wins || player2Wins) == false)
                draw = true;
            else if (player1Wins)
                winner = Player1;
            else
                winner = Player2;

            var result = new GameResult(winner, draw);
            Console.WriteLine(result);
            return result;
        }

        private static bool Attack(Player from, Player to)
        {
            var firstAttackerWins = from.Hand.Strength == to.Hand.Weakness;
            return firstAttackerWins;
        }

    }
}
