using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class SpockStrategy : IWeapon
    {
        public int Use()
        {
            int value =(int) Weapon.Spock;
            Console.WriteLine(Weapon.Spock);
            return value;
        }
    }
}
