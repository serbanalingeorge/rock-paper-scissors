using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RockPaperScissors.GameRules;
using RockPaperScissors.Helper;
using RockPaperScissors.StrategyPattern.Context;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Games
{
    public class ComputerVsComputer : BasicGame
    {
        public ComputerVsComputer()
        {
            Player1 = new ComputerPlayer();
            Player2 = new ComputerPlayer();
        }
        public override void Play()
        {
            var val1 = Player1.Attack();
            DisplayMessage.NewLine();
            var val2 = Player2.Attack();
            DisplayMessage.NewLine();
            
            ShowResult(val1, val2);
        }
    }
}
