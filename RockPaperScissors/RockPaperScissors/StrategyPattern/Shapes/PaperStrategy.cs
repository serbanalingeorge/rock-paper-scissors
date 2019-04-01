using System;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Shapes
{
    public class PaperStrategy : IWeapon
    {

        public Weapon Use()
        {
            Console.WriteLine("Player --> " + Weapon.Paper);
            return Weapon.Paper;
        }
    }
}
