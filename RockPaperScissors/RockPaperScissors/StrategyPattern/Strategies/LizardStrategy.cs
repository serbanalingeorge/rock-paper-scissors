using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Strategies
{
    public class LizardStrategy : IWeapon
    {
        public int Use()
        {
            var value =(int) Weapon.Lizard;
            Console.WriteLine(Weapon.Lizard);
            return value;
        }
    }
}
