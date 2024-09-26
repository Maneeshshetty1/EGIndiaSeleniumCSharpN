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
    internal class Checkboxes
    {


            IWebDriver driver;


            [SetUp]
            public void startChrome()
            {

                // confifgure the web driver manager to set up the chrome capabilities
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());


                // intialize the web driver 
                driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

           

                //


            }

            [Test]
            public void testcase1()
            {
            Thread.Sleep(3000);
                IWebElement Checkbox2 = driver.FindElement(By.XPath("(//input[@type='checkbox'])[2]"));
                Checkbox2.Click();



            }


            [TearDown]
            public void tearDownChrome()
            {
                //closing the current browser
                driver.Close();

            }

        }
    }

