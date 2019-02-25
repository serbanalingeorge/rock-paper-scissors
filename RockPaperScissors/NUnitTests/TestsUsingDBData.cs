using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.DBConnection;
using RockPaperScissors.GameRules;

namespace NUnitTests
{
    class DbTestData : CreateTransaction
    {
        private DbDataRules rule;

        private RetrieveData retrieveData;

        private string getRock = "SELECT shape FROM dbo.Shapes WHERE shapeID = 1";
        private string getPaper = "SELECT shape FROM dbo.Shapes WHERE shapeID = 2";
        private string getScissors = "SELECT shape FROM dbo.Shapes WHERE shapeID = 3";

        private string rock = "rock";
        private string paper = "paper";
        private string scissors = "scissors";
        private string invalid = "invalid";

        [SetUp]
        public void RetrieveDbData()
        {
            rule = new DbDataRules();
            retrieveData = new RetrieveData();
        }

        [Test]
        public void Returns_Win_For_Rock_And_Scissors()
        {
            string rock = retrieveData.RetrieveDbData(this.getRock);
            string result = rule.Winner(rock, scissors);
            Assert.AreEqual(Outcome.Won.ToString(),result);
        }

        [Test]
        public void Returns_Win_For_Scissors_And_Paper()
        {
            string scissors = retrieveData.RetrieveDbData(this.getScissors);
            string result = rule.Winner(scissors, paper);
            Assert.AreEqual(Outcome.Won.ToString(),result);
        }

        [Test]
        public void Returns_Win_For_Paper_And_Rock()
        {
            string paper = retrieveData.RetrieveDbData(this.getPaper);
            string result = rule.Winner(paper, rock);
            Assert.AreEqual(Outcome.Won.ToString(),result);
        }

        [Test]
        public void Returns_Lose_For_Paper_And_Scissors()
        {
            string paper = retrieveData.RetrieveDbData(getPaper);
            string result = rule.Winner(paper, scissors);
            Assert.AreEqual(Outcome.Lost.ToString(),result);
        }

        [Test]
        public void Returns_Lose_For_Rock_And_Paper()
        {
            string rock = retrieveData.RetrieveDbData(getRock);
            string result = rule.Winner(rock, paper);
            Assert.AreEqual(Outcome.Lost.ToString(),result);
        }

        [Test]
        public void Returns_Draw_For_Rock_And_Rock()
        {
            string rock = retrieveData.RetrieveDbData(getRock);
            string result = rule.Winner(rock, this.rock);
            Assert.AreEqual(Outcome.Draw.ToString(),result);
        }

        [Test]
        public void Returns_Draw_For_Paper_And_Paper()
        {
            string paper = retrieveData.RetrieveDbData(getPaper);
            string result = rule.Winner(paper, this.paper);
            Assert.AreEqual(Outcome.Draw.ToString(),result);
        }

        [Test]
        public void Returns_Draw_For_Scissors_And_Scissors()
        {
            string scissors = retrieveData.RetrieveDbData(getScissors);
            string result = rule.Winner(scissors, this.scissors);
            Assert.AreEqual(Outcome.Draw.ToString(),result);
        }

        [Test]
        public void Returns_Invalid()
        {
            string result = rule.Winner(invalid, invalid);
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_Rock_And_InvalidWeapon()
        {
            string rock = retrieveData.RetrieveDbData(getRock);
            string result = rule.Winner(rock, invalid);
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_Paper_And_InvalidWeapon()
        {
            string paper = retrieveData.RetrieveDbData(getPaper);
            string result = rule.Winner(paper, invalid);
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_Scissors_And_InvalidWeapon()
        {
            string scissors = retrieveData.RetrieveDbData(getScissors);
            string result = rule.Winner(scissors, invalid);
            Assert.AreEqual(Outcome.Invalid.ToString(),result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Rock()
        {
            string rock = retrieveData.RetrieveDbData(getRock);
            string result = rule.Winner(invalid,rock);
            Assert.AreEqual(Outcome.Invalid.ToString(), result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Paper()
        {
            string paper = retrieveData.RetrieveDbData(getPaper);
            string result = rule.Winner(invalid, paper);
            Assert.AreEqual(Outcome.Invalid.ToString(), result);
        }

        [Test]
        public void Returns_Invalid_For_InvalidWeapon_And_Scissors()
        {
            string scissors = retrieveData.RetrieveDbData(getScissors);
            string result = rule.Winner(invalid, scissors);
            Assert.AreEqual(Outcome.Invalid.ToString(), result);
        }

    }
}

