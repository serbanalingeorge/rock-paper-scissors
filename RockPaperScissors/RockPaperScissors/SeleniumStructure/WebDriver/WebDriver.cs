using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Web
{
    public class WebDriver
    {
        public static IWebDriver CreateFor(Driver driver)
        {
            switch (driver)
            {
                case Driver.Chrome:
                    var chromeOption = new ChromeOptions();
                    chromeOption.AddArgument("headless");
                    return new ChromeDriver(chromeOption);
                default:
                    return new FirefoxDriver();
            }
        }
    }
}
