using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RockPaperScissors.Enums;
using RockPaperScissors.Helper;

namespace RockPaperScissors.SeleniumStructure.PageFactory
{
    public class PageFactoryClass
    {
        /*public string NavigateToMainPage()
        {

            using (var driver = WebDriver.CreateFor(Driver.Chrome))
            {
                driver.Navigate().GoToUrl("https://www.instructables.com/id/How-to-Play-Rock-Paper-Scissors-Lizard-Spock/");
                var rock = driver.FindElement(By.CssSelector("#step1 > h2")).Text;
                var paper = driver.FindElement(By.CssSelector("#step2 > h2")).Text;
                var scissors = driver.FindElement(By.CssSelector("#step3 > h2")).Text;
                var lizard = driver.FindElement(By.CssSelector("#step4 > h2")).Text;
                var spock = driver.FindElement(By.CssSelector("#step5 > h2")).Text;

                var weapons = new List<string>
                {
                    rock,
                    paper,
                    scissors,
                    lizard,
                    spock
                };

                Console.WriteLine("Type: \n(1) for ROCK," +
                                  " \n(2) for PAPER," +
                                  " \n(3) for SCISSORS," +
                                  " \n(4) for LIZARD," +
                                  " \n(5) for SPOCK!");
                var userInput = Console.ReadLine();

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
        private IWebElement rockElement;

        [FindsBy(How = How.CssSelector, Using = "#step2 > h2")]
        private IWebElement paperElement;

        [FindsBy(How = How.CssSelector, Using = "#step3 > h2")]
        private IWebElement scissorsElement;

        [FindsBy(How = How.CssSelector, Using = "#step4 > h2")]
        private IWebElement lizardElement;

        [FindsBy(How = How.CssSelector, Using = "#step5 > h2")]
        private IWebElement spockElement;

        public void IWebElement()
        {
            webElements.Add(rockElement);
            webElements.Add(paperElement);
            webElements.Add(scissorsElement);
            webElements.Add(lizardElement);
            webElements.Add(spockElement);
        }*/
    }
}
