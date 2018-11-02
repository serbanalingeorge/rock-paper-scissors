using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class RandomStrategy : IWeapon
    {
        private Random random = new Random();
        public void Use()
        {
            Console.WriteLine((Weapon)random.Next(1, 4));
        }

        public void Action()
        {
            
        }
    }
}
