using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class DropDown
    {
        IWebDriver driver;
        [SetUp]
        public void StartChrome()
        {
            
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
           
            driver = new ChromeDriver();
            

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            
            IWebElement DropDown= driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown);

            var select = new SelectElement(DropDown);


            select.SelectByIndex(1);
            Thread.Sleep(1000);
            select.SelectByValue("option1");


            Thread.Sleep(1000);
            select.SelectByValue("option2");


        }

        [TearDown]
        public void tearDownChrome()
        {

            driver.Close();

        }

    }
}
