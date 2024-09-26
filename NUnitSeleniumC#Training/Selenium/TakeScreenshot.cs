using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class TakeScreenshot
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void run()
        {
            Thread.Sleep(1000);     
            Screenshot ss= driver.TakeScreenshot();

            ss.SaveAsFile("C:\\Users\\mashm\\Pictures\\Screenshots\\Screenshot 2024-08-06 210651.png");




        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
