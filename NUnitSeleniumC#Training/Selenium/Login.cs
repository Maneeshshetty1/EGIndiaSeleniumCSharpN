using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class LaunchChrome
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();

        }
        [Test]
        public void Run()
        {
            //launch chrome browser
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}

