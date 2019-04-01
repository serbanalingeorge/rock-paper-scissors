using NUnit.Framework;
using RockPaperScissors.GameRules;
using RockPaperScissors.HtmlReport;

namespace RockPaperScissors.Helper
{
    public class Base
    {
        public Rule Rule;

        [TearDown]
        public void CreateReport()
        {
            Html.Generate();
        }
        [SetUp]
        public void RetrieveData()
        {
            Rule = new Rule();
        }
    }
}
