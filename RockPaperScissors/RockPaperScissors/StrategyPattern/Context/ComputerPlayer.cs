using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.StrategyPattern.Interface;
using RockPaperScissors.StrategyPattern.Shapes;

namespace RockPaperScissors.StrategyPattern.Context
{
    public class ComputerPlayer : IPlayer
    {
        private IWeapon weapon;

        public Weapon Attack()
        {
            weapon = new RandomStrategy();
            return weapon.Use();
        }
    }
}
