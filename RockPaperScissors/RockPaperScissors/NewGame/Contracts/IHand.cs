using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.NewGame.Entities;

namespace RockPaperScissors.NewGame.Contracts
{
    public interface IHand
    {
        ActionEnum Weakness { get; }
        ActionEnum Strength { get; }
    }
}
