using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class RockStrategy : IWeapon
    {
        public int Use()
        {
            int value =(int) Weapon.Rock;
            Console.WriteLine(Weapon.Rock);
            return value;
        }
    }
}
