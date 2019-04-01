using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.GameRules;
using RockPaperScissors.Helper;
using RockPaperScissors.StrategyPattern.Context;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Games
{
    public class PlayerVsPlayer : BasicGame
    {
        public PlayerVsPlayer()
        {
            Player1 = new HumanPlayer();
            Player2 = new HumanPlayer();
        }
        public override void Play()
        {
            DisplayMessage.FirstPlayerTurn();
            var val1 = Player1.Attack();
            Console.Clear();
            DisplayMessage.SecondPlayerTurn();
            var val2 = Player2.Attack();
            Console.Clear();
            ShowResult(val1, val2);
        }
    }
}
