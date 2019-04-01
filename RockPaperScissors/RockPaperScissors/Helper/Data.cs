using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.StrategyPattern;

namespace RockPaperScissors.Helper
{
    public static class Shapes
    {
        public static string Rock()
        {
            return "rock";
        }

        public static string Paper()
        {
            return "paper";
        }

        public static string Scissors()
        {
            return "scissors";
        }

        public static string Invalid()
        {
            return "invalid";
        }
    }
}
