using System;
using RockPaperScissors.StrategyPattern;

namespace RockPaperScissors.GameRules
{
    public class Rule
    {
        public Outcome Winner(Weapon shape1, Weapon shape2)
        {
            if ((shape1 == Weapon.Rock && shape2 == Weapon.Scissors) ||
                (shape1 == Weapon.Paper && shape2 == Weapon.Rock) ||
                (shape1 == Weapon.Scissors && shape2 == Weapon.Paper))
            {
                Console.WriteLine("Result --> 1st Player " + Outcome.Won);
                return Outcome.Won;
            }
            if ((shape1 == Weapon.Rock && shape2 == Weapon.Paper) ||
                (shape1 == Weapon.Paper && shape2 == Weapon.Scissors) ||
                (shape1 == Weapon.Scissors && shape2 == Weapon.Rock))
            {
                Console.WriteLine("Result --> 1st Player " + Outcome.Lost);
                return Outcome.Lost;
            }
            if ((shape1 == Weapon.Rock && shape2 == Weapon.Rock) ||
                (shape1 == Weapon.Paper && shape2 == Weapon.Paper) ||
                (shape1 == Weapon.Scissors && shape2 == Weapon.Scissors))
            {
                Console.WriteLine("Result --> It is a " + Outcome.Draw);
                return Outcome.Draw;
            }
            Console.WriteLine(Outcome.Invalid);
            return Outcome.Invalid;
        }
    }
}
