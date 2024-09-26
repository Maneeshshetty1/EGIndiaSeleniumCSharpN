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
    internal class MultipleCheckboxes
    {
        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();

            string title = driver.Title;
            Console.WriteLine(title);

            //get the current url

            string currenturl = driver.Url;
            Console.WriteLine(currenturl);

            //fetch the page source of the html page

            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);

            //


        }

        [Test]
        public void testcase1()
        {

            Thread.Sleep(3000);
            IReadOnlyList<IWebElement> Checkboxes = driver.FindElements(By.XPath("(//input[@type = 'checkbox'])[2]"));
           
            foreach(IWebElement e in Checkboxes)
            {
                Console.WriteLine(e.Text);

                e.Click();
            }



        }


        [TearDown]
        public void tearDownBrowser()
        {
            //closing the current browser
            driver.Close();

        }
    }
}
