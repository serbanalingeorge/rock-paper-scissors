using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.StrategyPattern;
using RockPaperScissors.Web;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.NavigateToMainPage();

            game.DisplayGame();
            
            game.PlayerChooseGame();

            Console.ReadLine();
        }
    }
}
