using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class DragAndDrop
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {



            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));

            IWebElement Dest = driver.FindElement(By.XPath("//div[@id='column-b']"));

            new Actions(driver)
                .DragAndDrop(Source, Dest)
                .Perform();
            Thread.Sleep(1000);

        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
