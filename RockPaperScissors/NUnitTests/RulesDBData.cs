using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.Helper;
using RockPaperScissors.StrategyPattern;

namespace NUnitTests
{
    public class RulesDbData : BaseDb
    {
        [Test]
        public void Returns_Win_For_Rock_And_Scissors()
        {
            var rock = TestData.RetrieveDbData(SqlQuery.GetRock());
            var result = Rules.Winner(rock, Shapes.Scissors());
            Assert.AreEqual(Outcome.Won.ToString(),result);
        }

        [Test]
        public void Returns_Win_For_Scissors_And_Paper()
        {
            var scissors = TestData.RetrieveDbData(SqlQuery.GetScissors());
            var result = Rules.Winner(scissors, Shapes.Paper());
            Assert.AreEqual(Outcome.Won.ToString(),result);
        }

        [Test]
        public void Returns_Win_For_Paper_And_Rock()
        {
            var paper = TestData.RetrieveDbData(SqlQuery.GetPaper());
            var result = Rules.Winner(paper, Shapes.Rock());
            Assert.AreEqual(Outcome.Won.ToString(),result);
        }

        [Test]
        public void Returns_Lose_For_Paper_And_Scissors()
        {
            var paper = TestData.RetrieveDbData(SqlQuery.GetPaper());
            var result = Rules.Winner(paper, Shapes.Scissors());
            Assert.AreEqual(Outcome.Lost.ToString(),result);
        }

        [Test]
        public void Returns_Lose_For_Rock_And_Paper()
        {
            var rock = TestData.RetrieveDbData(SqlQuery.GetRock());
            var result = Rules.Winner(rock, Shapes.Paper());
            Assert.AreEqual(Outcome.Lost.ToString(),result);
        }

        [Test]
        public void Returns_Draw_For_Rock_And_Rock()
        {
            var rock = TestData.RetrieveDbData(SqlQuery.GetRock());
            var result = Rules.Winner(rock, Shapes.Rock());
            Assert.AreEqual(Outcome.Draw.ToString(),result);
        }

        [Test]
        public void Returns_Draw_For_Paper_And_Paper()
        {
            var paper = TestData.RetrieveDbData(SqlQuery.GetPaper());
            var result = Rules.Winner(paper, Shapes.Paper());
            Assert.AreEqual(Outcome.Draw.ToString(),result);
        }

        [Test]
        public void Returns_Draw_For_Scissors_And_Scissors()
        {
            var scissors = TestData.RetrieveDbData(SqlQuery.GetScissors());
            var result = Rules.Winner(scissors, Shapes.Scissors());
            Assert.AreEqual(Outcome.Draw.ToString(),result);
        }

        [Test]
        public void Returns_Invalid()
        {
            var result = Rules.Winner(Shapes.Invalid(), Shapes.Invalid());
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_Rock_And_InvalidWeapon()
        {
            var rock = TestData.RetrieveDbData(SqlQuery.GetRock());
            var result = Rules.Winner(rock, Shapes.Invalid());
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_Paper_And_InvalidWeapon()
        {
            var paper = TestData.RetrieveDbData(SqlQuery.GetPaper());
            var result = Rules.Winner(paper, Shapes.Invalid());
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_Scissors_And_InvalidWeapon()
        {
            var scissors = TestData.RetrieveDbData(SqlQuery.GetScissors());
            var result = Rules.Winner(scissors, Shapes.Invalid());
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Rock()
        {
            var rock = TestData.RetrieveDbData(SqlQuery.GetRock());
            var result = Rules.Winner(Shapes.Invalid(),rock);
            Assert.AreEqual(Outcome.Invalid.ToString(), result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Paper()
        {
            var paper = TestData.RetrieveDbData(SqlQuery.GetPaper());
            var result = Rules.Winner(Shapes.Invalid(), paper);
            Assert.AreEqual(Outcome.Invalid.ToString(), result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Scissors()
        {
            var scissors = TestData.RetrieveDbData(SqlQuery.GetScissors());
            var result = Rules.Winner(Shapes.Invalid(), scissors);
            Assert.AreEqual(Outcome.Invalid.ToString(), result);
        }

        [Test]
        public void ThisShouldFail()
        {
            Assert.Fail();
        }
    }
}

