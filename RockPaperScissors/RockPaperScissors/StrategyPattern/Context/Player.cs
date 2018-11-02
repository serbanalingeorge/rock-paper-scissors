using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.StrategyPattern
{
    public class Player
    {
        private static IWeapon weapon;
        private int wins;

        public void SetWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void Attack()
        {
            weapon.Use();
        }

        public int getWins()
        {
            return wins;
        }

        public void IncrementWins()
        {
            wins += 1;
        }
    }
}
