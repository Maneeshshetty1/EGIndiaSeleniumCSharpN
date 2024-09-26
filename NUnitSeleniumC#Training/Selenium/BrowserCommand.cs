using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class BrowserCommand
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

                string title =driver.Title;
                Console.WriteLine(title);

                //get the current url

                string currenturl =driver.Url;
                Console.WriteLine(currenturl);

                //fetch the page source of the html page

                string pagesource =driver.PageSource;
                Console.WriteLine(pagesource);

                //


            }

            [Test]
            public void testcase1()
            {
                driver.Navigate().GoToUrl("https://www.google.com/");
            }

            [TearDown]
            public void tearDownEdge()
            {
                //closing the current browser
                driver.Close();

               

            }
        }
    }
}