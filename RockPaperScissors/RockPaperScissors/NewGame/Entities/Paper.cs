using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.NewGame.Contracts;

namespace RockPaperScissors.NewGame.Entities
{
    public class Paper : IHand
    {
        public ActionEnum Weakness
        {
            get
            {
                return ActionEnum.Cut;
            }
        }

        public ActionEnum Strength
        {
            get
            {
                return ActionEnum.Cover;
            }
        }
    }
}
