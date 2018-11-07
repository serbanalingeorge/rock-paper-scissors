using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.StrategyPattern;

namespace NUnitTests
{
    class UnitTests
    {
        private Rule rule;

        [SetUp]
        public void Creation()
        {
            rule = new Rule();
        }
        //(1 WON) (0 DRAW) (-1 LOST)
        [Test]
        public void Returns_Win_For_Rock_And_Scissors()
        {

            int result = rule.DecideWinner((int)Weapon.Rock,(int)Weapon.Scissors);
            Assert.AreEqual((int)Outcome.Won, result);
        }

        [Test]
        public void Returns_Win_For_Scissors_And_Paper()
        {
            int result = rule.DecideWinner((int)Weapon.Scissors,(int)Weapon.Paper);
            Assert.AreEqual((int)Outcome.Won, result);
        }

        [Test]
        public void Returns_Win_For_Paper_And_Rock()
        {
            int result = rule.DecideWinner((int)Weapon.Paper,(int)Weapon.Rock);
            Assert.AreEqual((int)Outcome.Won, result);
        }

        [Test]
        public void Returns_Lose_For_Scissors_And_Rock()
        {
            int result = rule.DecideWinner((int)Weapon.Scissors,(int)Weapon.Rock);
            Assert.AreEqual((int)Outcome.Lost,result);
        }

        [Test]
        public void Returns_Lose_For_Paper_And_Scissors()
        {
            int result = rule.DecideWinner((int)Weapon.Paper,(int)Weapon.Scissors);
            Assert.AreEqual((int)Outcome.Lost, result);
        }

        [Test]
        public void Returns_Lose_For_Rock_And_Paper()
        {
            int result = rule.DecideWinner((int)Weapon.Rock,(int)Weapon.Paper);
            Assert.AreEqual((int)Outcome.Lost, result);
        }

        [Test]
        public void Returns_Draw_For_Rock_And_Rock()
        {
            int result = rule.DecideWinner((int)Weapon.Rock, (int)Weapon.Rock);
            Assert.AreEqual((int)Outcome.Draw, result);
        }

        [Test]
        public void Returns_Draw_For_Paper_And_Paper()
        {
            int result = rule.DecideWinner((int)Weapon.Paper, (int)Weapon.Paper);
            Assert.AreEqual((int)Outcome.Draw, result);
        }

        [Test]
        public void Returns_Draw_For_Scissors_And_Scissors()
        {
            int result = rule.DecideWinner((int)Weapon.Scissors, (int)Weapon.Scissors);
            Assert.AreEqual((int)Outcome.Draw, result);
        }

        [Test]
        public void Returns_Invalid()
        {
            int result = rule.DecideWinner((int) Weapon.Invalid, (int) Weapon.Invalid);
            Assert.AreEqual((int)Outcome.Invalid,result);
        }

        [Test]
        public void Returns_Invalid_For_Rock_And_InvalidWeapon()
        {
            int result = rule.DecideWinner((int) Weapon.Rock, (int) Weapon.Invalid);
            Assert.AreEqual((int)Outcome.Invalid,result);
        }

        [Test]
        public void Returns_Invalid_For_Paper_And_InvalidWeapon()
        {
            int result = rule.DecideWinner((int)Weapon.Paper, (int)Weapon.Invalid);
            Assert.AreEqual((int)Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_Scissors_And_InvalidWeapon()
        {
            int result = rule.DecideWinner((int)Weapon.Scissors, (int)Weapon.Invalid);
            Assert.AreEqual((int)Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Rock()
        {
            int result = rule.DecideWinner((int)Weapon.Invalid, (int)Weapon.Rock);
            Assert.AreEqual((int)Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Paper()
        {
            int result = rule.DecideWinner((int)Weapon.Invalid, (int)Weapon.Paper);
            Assert.AreEqual((int)Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Scissors()
        {
            int result = rule.DecideWinner((int)Weapon.Invalid, (int)Weapon.Scissors);
            Assert.AreEqual((int)Outcome.Invalid, result);
        }
    }
}

