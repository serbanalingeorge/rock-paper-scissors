using System;

namespace RockPaperScissors.GameRules
{
    public class Rule
    {
        public int Winner(int shape1, int shape2)
        {
            if ((shape1 == 1 && shape2 == 3) ||
                (shape1 == 2 && shape2 == 1) ||
                (shape1 == 3 && shape2 == 2))
            {
                Console.WriteLine("Player/Computer 1 " + Outcome.Won);
                return (int)Outcome.Won;
            }
            else if ((shape1 == 1 && shape2 == 2) ||
                     (shape1 == 2 && shape2 == 3) ||
                     (shape1 == 3 && shape2 == 1))
            {
                Console.WriteLine("Player/Computer 1 " + Outcome.Lost);
                return (int)Outcome.Lost;
            }
            else if ((shape1 == 1 && shape2 == 1) ||
                     (shape1 == 2 && shape2 == 2) ||
                     (shape1 == 3 && shape2 == 3))
            {
                Console.WriteLine("It is a " + Outcome.Draw);
                return (int)Outcome.Draw;
            }
            else
            {
                Console.WriteLine(Outcome.Invalid);
                return (int)Outcome.Invalid;
            }
        }
    }
}
