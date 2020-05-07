using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestWSEI
{

    [TestFixture]
    public class FacebookLoginFormTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:/Users/stere/Desktop/seleniumtest/ewlo");
        }

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("http://www.facebook.com");
            driver.FindElement(By.Id("email")).SendKeys("emailid");
            driver.FindElement(By.Id("pass")).SendKeys("password");
            driver.FindElement(By.Id("u_0_l")).Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}