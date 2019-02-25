using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Strategies
{
    public class SpockStrategy : IWeapon
    {
        public int Use()
        {
            var value =(int) Weapon.Spock;
            Console.WriteLine(Weapon.Spock);
            return value;
        }
    }
}
