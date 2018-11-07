using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class ScissorsStrategy : IWeapon
    {
        public int Use()
        {
            int value =(int) Weapon.Scissors;
            Console.WriteLine(Weapon.Scissors);
            return value;
        }
    }
}
