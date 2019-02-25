using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Strategies
{
    public class PaperStrategy : IWeapon
    {

        public int Use()
        {
            var value =(int) Weapon.Paper;
            Console.WriteLine(Weapon.Paper);
            return value;
        }
    }
}
