using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class KeyBoardActions
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase1()
        {

            new Actions(driver)
             .KeyUp(Keys.Shift)
             .SendKeys("A")
             .Perform();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownChrome()
        {
            driver.Close();
        }
    }
}
    
