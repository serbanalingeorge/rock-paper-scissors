using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.NewGame.Contracts;

namespace RockPaperScissors.NewGame.Entities
{
    public class Scissors : IHand
    {
        public ActionEnum Weakness
        {
            get
            {
                return ActionEnum.Smash;
            }
        }

        public ActionEnum Strength
        {
            get
            {
                return ActionEnum.Cut;
            }
        }
    }
}
