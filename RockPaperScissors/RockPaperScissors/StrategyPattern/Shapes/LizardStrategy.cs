using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Shapes
{
    public class LizardStrategy : IWeapon
    {
        public Weapon Use()
        {
            Console.WriteLine("Player --> " + Weapon.Lizard);
            return Weapon.Lizard;
        }
    }
}
