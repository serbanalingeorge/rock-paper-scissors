using System;
using RockPaperScissors.StrategyPattern.Interface;
using RockPaperScissors.StrategyPattern.Strategies;

namespace RockPaperScissors.StrategyPattern.Context
{
    public class Player : IPlayer
    {
        private static IWeapon _weapon;

        public void SetWeapon(IWeapon newWeapon)
        {
            _weapon = newWeapon;
        }

        public int Attack()
        {
            return (int) _weapon.Use();
        }


        public int Play()
        {
            DisplayMessage.Weapon();
            
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    _weapon = new RockStrategy();
                    return (int) Weapon.Rock;
                case "2":
                    _weapon = new PaperStrategy();
                    return (int) Weapon.Paper;
                case "3":
                    _weapon = new ScissorsStrategy();
                    return (int) Weapon.Scissors;
                default:
                    return (int) Weapon.Invalid;
            }
        }

    }
}
