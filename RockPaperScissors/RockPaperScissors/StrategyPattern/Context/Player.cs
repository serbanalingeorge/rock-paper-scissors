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

        public int Attack()
        {
            return (int) weapon.Use();
        }
        public int getWins()
        {
            return wins;
        }

        public void IncrementWins()
        {
            wins += 1;
        }

        public int PlayerStartGame()
        {
            Console.WriteLine("Type: \n(1) for ROCK," +
                              " \n(2) for PAPER," +
                              " \n(3) for SCISSORS!");

            string input = Console.ReadLine();

            if (input == "1")
            {
                SetWeapon(new RockStrategy());
                Attack();
                return  (int)Weapon.Rock;
            }
            else if (input == "2")
            {
                SetWeapon(new PaperStrategy());
                Attack();
                return (int)Weapon.Paper;
            }
            else if (input == "3")
            {
                SetWeapon(new ScissorsStrategy());
                Attack();
                return (int)Weapon.Scissors;
            }
            else
            {
                return -2;
            }
        }

    }
}
