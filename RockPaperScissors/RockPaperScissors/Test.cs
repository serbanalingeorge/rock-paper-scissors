using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace RockPaperScissors
{
    class Test
    {
        private Oponent oponent;
        [SetUp]
        public void Creation()
        {
            oponent = new Oponent();
        }

        [Test]
        public void Returns_Win_For_Rock_And_Scissors()
        {
            string result = oponent.Result("rock", "scissors");
            Assert.AreEqual("You win!", result);
        }

        [Test]
        public void Returns_Win_For_Scissors_And_Paper()
        {
            string result = oponent.Result("scissors", "paper");
            Assert.AreEqual("You win!", result);
        }

        [Test]
        public void Returns_Win_For_Paper_And_Rock()
        {
            string result = oponent.Result("paper", "rock");
            Assert.AreEqual("You win!", result);
        }

        [Test]
        public void Returns_Lose_For_Scissors_And_Rock()
        {
            string result = oponent.Result("scissors", "rock");
            Assert.AreEqual("You lose!", result);
        }

        [Test]
        public void Returns_Lose_For_Paper_And_Scissors()
        {
            string result = oponent.Result("paper", "scissors");
            Assert.AreEqual("You lose!", result);
        }

        [Test]
        public void Returns_Lose_For_Rock_And_Paper()
        {
            string result = oponent.Result("rock", "paper");
            Assert.AreEqual("You lose!", result);
        }

        [Test]
        public void Returns_Draw_For_Rock_And_Rock()
        {
            string result = oponent.Result("rock", "rock");
            Assert.AreEqual("A draw!", result);
        }

        [Test]
        public void Returns_Draw_For_Paper_And_Paper()
        {
            string result = oponent.Result("paper", "paper");
            Assert.AreEqual("A draw!", result);
        }

        [Test]
        public void Returns_Draw_For_Scissors_And_Scissors()
        {
            string result = oponent.Result("scissors", "scissors");
            Assert.AreEqual("A draw!", result);
        }

        [Test]
        public void Returns_Message_For_Non_RPS_Choise()
        {
            string result = oponent.Result("", "");
            Assert.AreEqual("You didn't make a sensible choice!", result);
        }
    }
}
