using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class LaunchEdge
    {
        IWebDriver driver;


        [SetUp]
        public void startEdge()
        {
           
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();


        }

        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [TearDown]
        public void tearDownEdge()
        {

            driver.Close();

        }
    }
}
