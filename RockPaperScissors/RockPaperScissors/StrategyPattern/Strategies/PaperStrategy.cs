using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class PaperStrategy : IWeapon
    {
        public void Use()
        {
            Console.WriteLine(Weapon.Paper);
        }

    }
}
