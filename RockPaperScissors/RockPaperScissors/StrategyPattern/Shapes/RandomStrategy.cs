using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using RockPaperScissors.StrategyPattern.Interface;

namespace RockPaperScissors.StrategyPattern.Shapes
{
    public class RandomStrategy : IWeapon
    {
        private static readonly Random Random = new Random();
        
        public Weapon Use()
        {
            var shapes = new List<Weapon>
            {
                Weapon.Rock,
                Weapon.Paper,
                Weapon.Scissors,
                Weapon.Spock,
                Weapon.Lizard
            };
            
            var choose = Random.Next(0, 3);
            
            Console.Write("Computer --> " + shapes[choose]);
            return shapes[choose];
        }
    }
}
