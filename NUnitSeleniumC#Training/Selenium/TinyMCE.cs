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
    internal class TinyMCE
    {

        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            // fetch the handle of the parent page

            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@id='mce_0_ifr']"));

            driver.SwitchTo().Frame(Frame1);

            IWebElement click = driver.FindElement(By.TagName("p"));
            click.Clear();

            click.SendKeys("Hello");
            Thread.Sleep(5000);
        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
