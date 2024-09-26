using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class VerticalScrolling
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
            Thread.Sleep(3000);

            

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //0 -x-coordinate

            //500- y-coordinate
            js.ExecuteScript("window.scrollBy(0,500)", "");

            //0 -x-coordinate

            //-300- y-coordinate


            js.ExecuteScript("window.scrollBy(0,-300)", "");


            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(3000);
        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
