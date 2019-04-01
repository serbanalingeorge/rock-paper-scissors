using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.GameRules;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Games
{
    public abstract class BasicGame : IGame
    {
        private readonly Rule rule = new Rule();
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }
        public abstract void Play();

        public void ShowResult(Weapon value1, Weapon value2)
        {
            rule.Winner(value1, value2);
        }
    }
}
