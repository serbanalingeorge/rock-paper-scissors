using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RockPaperScissors.Enums;
using RockPaperScissors.Web;

namespace RockPaperScissors.SeleniumStructure.PageFactory
{
    class PageFactoryClass
    {
        public string NavigateToMainPage()
        {

            using (var driver = WebDriver.CreateFor(Driver.Chrome))
            {
                driver.Navigate().GoToUrl("https://www.instructables.com/id/How-to-Play-Rock-Paper-Scissors-Lizard-Spock/");
                string rock = driver.FindElement(By.CssSelector("#step1 > h2")).Text;
                string paper = driver.FindElement(By.CssSelector("#step2 > h2")).Text;
                string scissors = driver.FindElement(By.CssSelector("#step3 > h2")).Text;
                string lizard = driver.FindElement(By.CssSelector("#step4 > h2")).Text;
                string spock = driver.FindElement(By.CssSelector("#step5 > h2")).Text;

                List<string> weapons = new List<string>();
                weapons.Add(rock);
                weapons.Add(paper);
                weapons.Add(scissors);
                weapons.Add(lizard);
                weapons.Add(spock);

                Console.WriteLine("Type: \n(1) for ROCK," +
                                  " \n(2) for PAPER," +
                                  " \n(3) for SCISSORS," +
                                  " \n(4) for LIZARD," +
                                  " \n(5) for SPOCK!");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(weapons.Find(w => w == rock));
                        break;
                    case "2":
                        Console.WriteLine(weapons.Find(w => w == paper));
                        break;
                    case "3":
                        Console.WriteLine(weapons.Find(w => w == scissors));
                        break;
                    case "4":
                        Console.WriteLine(weapons.Find(w => w == lizard));
                        break;
                    case "5":
                        Console.WriteLine(weapons.Find(w => w == spock));
                        break;
                    default:
                        DisplayMessage.NotValid();
                        break;
                }
                return null;
            }
        }
        List<IWebElement> webElements = new List<IWebElement>();

        [FindsBy(How = How.CssSelector, Using = "#step1 > h2")]
        private IWebElement rock;

        [FindsBy(How = How.CssSelector, Using = "#step2 > h2")]
        private IWebElement paper;

        [FindsBy(How = How.CssSelector, Using = "#step3 > h2")]
        private IWebElement scissors;

        [FindsBy(How = How.CssSelector, Using = "#step4 > h2")]
        private IWebElement lizard;

        [FindsBy(How = How.CssSelector, Using = "#step5 > h2")]
        private IWebElement spock;

        public void IWebElement()
        {
            webElements.Add(rock);
            webElements.Add(paper);
            webElements.Add(scissors);
            webElements.Add(lizard);
            webElements.Add(spock);
        }
    }
}
