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
    internal class OpenWindow
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            // fetch the handle of the parent page

            string currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            // click on the link to open the new window

            IWebElement Open = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            Open.Click();


            new Actions(driver)
            .KeyUp(Keys.Shift)
            .SendKeys("Click Here")
            .Perform();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
