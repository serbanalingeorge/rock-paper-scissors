using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Rule
    {
        private int[,] rule = new int[3, 3]
        {
            { 0,-1, 1},
            { 1, 0,-1},
            {-1, 1, 0}
        };

        public int DecideWinner(int shape1, int shape2)
        {
            if ((shape1 == 1 && shape2 == 3) ||
                (shape1 == 2 && shape2 == 1) ||
                (shape1 == 3 && shape2 == 2))
            {
                return (int)Outcome.Won;
            }
            else if ((shape1 == 1 && shape2 == 2) ||
                     (shape1 == 2 && shape2 == 3) ||
                     (shape1 == 3 && shape2 == 1))
            {
                return (int)Outcome.Lost;
            }
            else if ((shape1 == 1 && shape2 == 1) ||
                     (shape1 == 2 && shape2 == 2) ||
                     (shape1 == 3 && shape2 == 3))
            {
                return (int)Outcome.Draw;
            }
            else
            {
                return (int)Outcome.Invalid;
            }
        }
    }
}
