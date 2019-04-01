using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Shapes
{
    public class SpockStrategy : IWeapon
    {
        public Weapon Use()
        {
            Console.WriteLine("Player --> " + Weapon.Spock);
            return Weapon.Spock;
        }
    }
}
