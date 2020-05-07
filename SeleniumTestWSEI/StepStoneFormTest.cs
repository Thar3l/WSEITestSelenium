using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestWSEI
{

    [TestFixture]
    public class StepStoneFormTest
    {
        IWebDriver driver;
        string testFormString;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:/Users/stere/Desktop/seleniumtest/ewlo");

            for (int i = 0; i < 100; i++)
                testFormString += "@@@@@@@@@@";
        }

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://www.stepstone.pl/");
            driver.FindElement(By.Name("ke")).SendKeys(testFormString);
            driver.FindElement(By.Name("ws")).SendKeys("31-001");
            driver.FindElement(By.Name("wt")).Click();
            driver.FindElement(By.ClassName("search-box__submit")).Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}