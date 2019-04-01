using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Shapes
{
    public class ScissorsStrategy : IWeapon
    {
        public Weapon Use()
        {
            Console.WriteLine("Player --> " + Weapon.Scissors);
            return Weapon.Scissors;
        }
    }
}
