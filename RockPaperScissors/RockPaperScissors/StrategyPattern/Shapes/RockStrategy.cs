using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Shapes
{
    public class RockStrategy : IWeapon
    {
        public Weapon Use()
        {
            Console.WriteLine("Player --> " + Weapon.Rock);
            return Weapon.Rock;
        }
    }
}
