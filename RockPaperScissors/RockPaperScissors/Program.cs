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

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IWeapon weapon = null;*/
            Player player = new Player();
            player.SetWeapon(new PaperStrategy());
            player.Attack();
            RandomStrategy computer = new RandomStrategy();
            computer.Use();

            computer.Use();
            Console.ReadLine();
        }
    }
}
