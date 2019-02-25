using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.GameRules
{
    public class DbDataRules
    {
        public string Winner(string shape1, string shape2)
        {
            if ((shape1 == "rock" && shape2 == "scissors") ||
                (shape1 == "paper" && shape2 == "rock") ||
                (shape1 == "scissors" && shape2 == "paper"))
            {
                Console.WriteLine(Outcome.Won);
                return Outcome.Won.ToString();
            }
            else if ((shape1 == "rock" && shape2 == "paper") ||
                     (shape1 == "paper" && shape2 == "scissors") ||
                     (shape1 == "scissors" && shape2 == "1"))
            {
                Console.WriteLine(Outcome.Lost);
                return Outcome.Lost.ToString();
            }
            else if ((shape1 == "rock" && shape2 == "rock") ||
                     (shape1 == "paper" && shape2 == "paper") ||
                     (shape1 == "scissors" && shape2 == "scissors"))
            {
                Console.WriteLine(Outcome.Draw);
                return Outcome.Draw.ToString();
            }
            else
            {
                Console.WriteLine(Outcome.Invalid);
                return Outcome.Invalid.ToString();
            }
        }
    }
}
