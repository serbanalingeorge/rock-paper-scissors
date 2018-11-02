using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.Classes;

namespace NUnitTests
{
    class UnitTests
    {
        
        private RandomPlayer oponent;
        [SetUp]
        public void Creation()
        {
            oponent = new RandomPlayer();
        }
        [Test]
        public void Returns_Win_For_Rock_And_Scissors()
        {

            string result = oponent.Result("rock", "scissors");
            Assert.AreEqual(oponent.message2, result);
        }

        [Test]
        public void Returns_Win_For_Scissors_And_Paper()
        {
            string result = oponent.Result("scissors", "paper");
            Assert.AreEqual(oponent.message2, result);
        }

        [Test]
        public void Returns_Win_For_Paper_And_Rock()
        {
            string result = oponent.Result("paper", "rock");
            Assert.AreEqual(oponent.message2, result);
        }

        [Test]
        public void Returns_Lose_For_Scissors_And_Rock()
        {
            string result = oponent.Result("scissors", "rock");
            Assert.AreEqual(oponent.message3,result);
        }

        [Test]
        public void Returns_Lose_For_Paper_And_Scissors()
        {
            string result = oponent.Result("paper", "scissors");
            Assert.AreEqual(oponent.message3, result);
        }

        [Test]
        public void Returns_Lose_For_Rock_And_Paper()
        {
            string result = oponent.Result("rock", "paper");
            Assert.AreEqual(oponent.message3, result);
        }

        [Test]
        public void Returns_Draw_For_Rock_And_Rock()
        {
            string result = oponent.Result("rock", "rock");
            Assert.AreEqual(oponent.message4, result);
        }

        [Test]
        public void Returns_Draw_For_Paper_And_Paper()
        {
            string result = oponent.Result("paper", "paper");
            Assert.AreEqual(oponent.message4, result);
        }

        [Test]
        public void Returns_Draw_For_Scissors_And_Scissors()
        {
            string result = oponent.Result("scissors", "scissors");
            Assert.AreEqual(oponent.message4, result);
        }

        [Test]
        public void Returns_Message_For_Non_RPS_Choise()
        {
            string result = oponent.Result("", "");
            Assert.AreEqual(oponent.message1, result);
        }
    }
}

