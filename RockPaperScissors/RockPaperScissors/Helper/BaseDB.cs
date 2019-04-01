using System.Collections.Generic;
using NUnit.Framework;
using RockPaperScissors.DBConnection;
using RockPaperScissors.GameRules;
using RockPaperScissors.HtmlReport;

namespace RockPaperScissors.Helper
{
    public class BaseDb : CreateTransaction
    {
        public DbDataRules Rules;
        public RetrieveData TestData;
        
        [TearDown]
        public void CreateReport()
        {
            Html.Generate();
        }
        [SetUp]
        public void RetrieveData()
        {
            Rules = new DbDataRules();
            TestData = new RetrieveData();
        }
    }
}
