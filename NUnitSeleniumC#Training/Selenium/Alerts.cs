using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class Alerts
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);

            IWebElement SimpleAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Alert')]"));
            SimpleAlert.Click();

            IAlert alt = driver.SwitchTo().Alert();
            alt.Accept();

            Thread.Sleep(3000);

            IWebElement ConfAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')]"));
            ConfAlert.Click();

            alt = driver.SwitchTo().Alert();
            alt.Dismiss();

            Thread.Sleep(3000);

            IWebElement PromptAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Prompt')]"));
            PromptAlert.Click();

            alt = driver.SwitchTo().Alert();
            string alerttext = alt.Text;
            Console.WriteLine(alerttext);

            alt.SendKeys("Hello Guys");
            Thread.Sleep(2000);
            alt.Accept();
        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
