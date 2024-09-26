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
    internal class Frameseg
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {



            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));


            //Selector frame
            driver.SwitchTo().Frame(Frame1);


            //select frame using index

            driver.SwitchTo().Frame(1);

            //select the frame using ID or name

            driver.SwitchTo().Frame("Frameone");


            //click on radio button

            IWebElement radiobutton = driver.FindElement(By.XPath("//span[@class='ui-checkboxradio-icon]"));
            radiobutton.Click();

            Thread.Sleep(1000);

        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
