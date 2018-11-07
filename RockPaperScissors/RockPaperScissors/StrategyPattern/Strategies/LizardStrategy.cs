using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class LizardStrategy : IWeapon
    {
        public int Use()
        {
            int value =(int) Weapon.Lizard;
            Console.WriteLine(Weapon.Lizard);
            return value;
        }
    }
}
