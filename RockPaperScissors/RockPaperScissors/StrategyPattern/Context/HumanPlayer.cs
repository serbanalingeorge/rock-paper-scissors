using System;
using RockPaperScissors.Helper;
using RockPaperScissors.StrategyPattern.Interface;
using RockPaperScissors.StrategyPattern.Shapes;

namespace RockPaperScissors.StrategyPattern.Context
{
    public class HumanPlayer : IPlayer
    {
        public Weapon Attack()
        {
            DisplayMessage.Weapon();

            var input = Console.ReadLine();

            return Use(SelectedWeapon(input));
        }

        private static IWeapon SelectedWeapon(string input)
        {
            switch (input)
            {
                case "1":
                    Console.Clear();
                    return new RockStrategy();
                case "2":
                    Console.Clear();
                    return new PaperStrategy();
                case "3":
                    Console.Clear();
                    return new ScissorsStrategy();
                default:
                    Console.Clear();
                    return new RockStrategy();
            }
        }

        private static Weapon Use(IWeapon weapon)
        {
            return weapon.Use();
        }
    }
}
