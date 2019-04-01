using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.Helper;
using RockPaperScissors.StrategyPattern;

namespace NUnitTests
{
    public class Rules : Base
    {
        //(1 WON) (0 DRAW) (-1 LOST)
        [Test]
        public void Returns_Win_For_Rock_And_Scissors()
        {

            var result = Rule.Winner(Weapon.Rock,Weapon.Scissors);
            Assert.AreEqual(Outcome.Won, result);
        }

        [Test]
        public void Returns_Win_For_Scissors_And_Paper()
        {
            var result = Rule.Winner(Weapon.Scissors,Weapon.Paper);
            Assert.AreEqual(Outcome.Won, result);
        }

        
        [Test]
        public void Returns_Win_For_Paper_And_Rock()
        {
            var result = Rule.Winner(Weapon.Paper,Weapon.Rock);
            Assert.AreEqual(Outcome.Won, result);
        }

        [Test]
        public void Returns_Lose_For_Scissors_And_Rock()
        {
            var result = Rule.Winner(Weapon.Scissors,Weapon.Rock);
            Assert.AreEqual(Outcome.Lost,result);
        }

        [Test]
        public void Returns_Lose_For_Paper_And_Scissors()
        {
            var result = Rule.Winner(Weapon.Paper,Weapon.Scissors);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [Test]
        public void Returns_Lose_For_Rock_And_Paper()
        {
            var result = Rule.Winner(Weapon.Rock,Weapon.Paper);
            Assert.AreEqual(Outcome.Lost, result);
        }

        [Test]
        public void Returns_Draw_For_Rock_And_Rock()
        {
            var result = Rule.Winner(Weapon.Rock, Weapon.Rock);
            Assert.AreEqual(Outcome.Draw, result);
        }

        [Test]
        public void Returns_Draw_For_Paper_And_Paper()
        {
            var result = Rule.Winner(Weapon.Paper,Weapon.Paper);
            Assert.AreEqual(Outcome.Draw, result);
        }

        [Test]
        public void Returns_Draw_For_Scissors_And_Scissors()
        {
            var result = Rule.Winner(Weapon.Scissors,Weapon.Scissors);
            Assert.AreEqual(Outcome.Draw, result);
        }

        [Test]
        public void Returns_Invalid()
        {
            var result = Rule.Winner(Weapon.Invalid, Weapon.Invalid);
            Assert.AreEqual(Outcome.Invalid,result);
        }

        [Test]
        public void Returns_Invalid_For_Rock_And_InvalidWeapon()
        {
            var result = Rule.Winner(Weapon.Rock,Weapon.Invalid);
            Assert.AreEqual(Outcome.Invalid,result);
        }

        [Test]
        public void Returns_Invalid_For_Paper_And_InvalidWeapon()
        {
            var result = Rule.Winner(Weapon.Paper, Weapon.Invalid);
            Assert.AreEqual(Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_Scissors_And_InvalidWeapon()
        {
            var result = Rule.Winner(Weapon.Scissors, Weapon.Invalid);
            Assert.AreEqual(Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Rock()
        {
            var result = Rule.Winner(Weapon.Invalid, Weapon.Rock);
            Assert.AreEqual(Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Paper()
        {
            var result = Rule.Winner(Weapon.Invalid, Weapon.Paper);
            Assert.AreEqual(Outcome.Invalid, result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Scissors()
        {
            var result = Rule.Winner(Weapon.Invalid, Weapon.Scissors);
            Assert.AreEqual(Outcome.Invalid, result);
        }

        [Test]
        public void This_Should_Fail()
        {
            Assert.Fail();
        }

        [Test]
        public void ThisShouldBeIgnored()
        {
            Assert.Ignore();
        }

        [Test]
        public void ThisShouldBeInconclusive()
        {
            Assert.Inconclusive();
        }
    }
}

