using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.NewGame.Entities
{
    public class GameResult
    {
        public GameResult(Player winner, bool draw)
        {
            Winner = winner;
            Draw = draw;
        }
        public Player Winner { get; set; }

        public bool Draw { get; set; }
    }
}
