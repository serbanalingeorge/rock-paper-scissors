using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using RockPaperScissors.NewGame.Contracts;

namespace RockPaperScissors.NewGame.Entities
{
    public class Player
    {
        public Player(string name, IHand hand)
        {
            Name = name;
            Hand = hand;
        }

        public string Name { get; set; }
        public IHand Hand { get; set; }
    }
}
