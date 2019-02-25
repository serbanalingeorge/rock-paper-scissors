using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Strategies
{
    public class RandomStrategy : IWeapon
    {
        private Random random = new Random();
        public int Use()
        {
            var value =(int) ((Weapon) random.Next(1, 4));
            Console.Write("Computer --> " + value);
            return value;
        }
    }
}
