using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors.NewGame.Entities;
using RockPaperScissors.StrategyPattern.Context;
using Game = RockPaperScissors.NewGame.Entities.Game;
using Player = RockPaperScissors.NewGame.Entities.Player;

namespace NUnitTests
{
    
    public class Player1
    {
        [Test]
        public void Draw_For_Rock_Rock()
        {
            var player1 = new Player("player1", new Rock());
            var player2 = new Player("player2", new Rock());

            var game = new Game(player1,player2);
            var result = game.Play();

            Assert.True(result.Draw);
            Assert.IsNull(result.Winner);
        }

        [Test]
        public void Draw_For_Paper_Paper()
        {
            var player1 = new Player("player1", new Paper());
            var player2 = new Player("player2", new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.True(result.Draw);
            Assert.IsNull(result.Winner);
        }

        [Test]
        public void Draw_For_Scissors_Scissors()
        {
            var player1 = new Player("player1", new Scissors());
            var player2 = new Player("player2", new Scissors());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.True(result.Draw);
            Assert.IsNull(result.Winner);
        }

        [Test]
        public void Win_For_Paper_Rock()
        {
            var player1 = new Player("player1", new Rock());
            var player2 = new Player("player2", new Paper());

            var game = new Game(player1, player2);
            var result = game.Play();

            Assert.AreSame(player2,result.Winner);
        }

        [Test]
        public void Win_For_Rock_Scissors()
        {
            var player1 = new Player("player1", new Rock());
            var player2 = new Player("player2", new Scissors());

            var game = new Game(player1,player2);
            var result = game.Play();

            Assert.AreEqual(player1,result.Winner);
        }

        [Test]
        public void Win_For_Scissors_Paper()
        {
            var player1 = new Player("player1", new Scissors());
            var player2 = new Player("player2", new Paper());

            var game = new Game(player1,player2);
            var result = game.Play();

            Assert.AreEqual(player1,result.Winner);
        }
    }

}
