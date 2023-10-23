using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V118.IndexedDB;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testloop2.Test
{
    internal class Selenium
    {
        [Test]
        public void fisrtTestcase()
        {
            Random rnd1 = new Random();
            int randomNumber1 = rnd1.Next(0, 500);

            Random rnd2 = new Random();
            int randomNumber2 = rnd2.Next(0, 500);

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://jcibe--eodbprjcts.sandbox.my.site.com/SolutionNavigator/s/login/?language=en_US&country=US&region=NAM");
            //driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            Assert.That(driver.Title, Is.EqualTo("Login"));
            Actions action = new Actions(driver);
            action.SendKeys(Keys.F11);
            action.Build().Perform();
            action.MoveByOffset(randomNumber1, randomNumber2).ContextClick().Perform();
            action.GetActiveKeyboard();
            Thread.Sleep(1000);
            driver.Quit();



        }

    }
}
