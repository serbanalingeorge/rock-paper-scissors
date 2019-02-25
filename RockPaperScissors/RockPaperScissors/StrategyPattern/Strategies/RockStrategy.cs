using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Strategies
{
    public class RockStrategy : IWeapon
    {
        public int Use()
        {
            var value =(int) Weapon.Rock;
            Console.WriteLine(Weapon.Rock);
            return value;
        }
    }
}
