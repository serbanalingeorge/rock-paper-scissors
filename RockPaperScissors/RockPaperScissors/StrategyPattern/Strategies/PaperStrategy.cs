using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class PaperStrategy : IWeapon
    {

        public int Use()
        {
            int value =(int) Weapon.Paper;
            Console.WriteLine(Weapon.Paper);
            return value;
        }
    }
}
