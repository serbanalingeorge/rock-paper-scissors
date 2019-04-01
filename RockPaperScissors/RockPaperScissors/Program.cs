using System;
using System.Threading;
using RockPaperScissors.Helper;
using RockPaperScissors.StrategyPattern.Context;
using RockPaperScissors.StrategyPattern.Games;
using RockPaperScissors.StrategyPattern.Interface;
using RockPaperScissors.StrategyPattern.Shapes;
using Game = RockPaperScissors.StrategyPattern.Context.Game;



namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            DisplayMessage.Welcome();
            game.Play();

            //-------------------------------

            /*var player1 = new Player("player1", new Rock());
            var player2 = new Player("player2", new Rock());

            var game = new NewGame.Entities.Game(player1,player2);
            var result = game.Play();

            Console.WriteLine("Result is: " + result.Draw);*/

            //------------------------------------

            /*GenericClass<IGame> game = new GenericClass<IGame>(new PlayerVsPlayer());

            var val = game.GenericMethod(new PlayerVsPlayer());*/
          
            Console.ReadLine();
        }

       
    }
}
