using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace SeleniumGridTests
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void SetUp()
        {
            
        }
        [Test]
        [Parallelizable]
        public void FirstTest()
        {
            DesiredCapabilities caps1 = new DesiredCapabilities();
            //caps1.SetCapability("platform", "WIN10");
            caps1.SetCapability("browserName", "chrome"); // name of your browser
            //caps1.SetCapability("network", true); // To enable network logs
            //caps1.SetCapability("visual", true); // To enable step by step screenshot
            //caps1.SetCapability("video", true); // To enable video recording
            //caps1.SetCapability("console", true); // To capture console logs
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), caps1, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl("http://www.google.com/");
            IWebElement query = driver.FindElement(By.Name("q"));
            driver.Quit();
        }

        [Test]
        [Parallelizable]
        public void SecondTest()
        {
            DesiredCapabilities caps2 = new DesiredCapabilities();
            caps2.SetCapability("browserName", "internet explorer"); // name of your browser
            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), caps2, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl("http://github.com");
            driver.Quit();
        }
    }
}
