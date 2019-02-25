using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Strategies
{
    public class ScissorsStrategy : IWeapon
    {
        public int Use()
        {
            var value = (int) Weapon.Scissors;
            Console.WriteLine(Weapon.Scissors);
            return value;
        }
    }
}
