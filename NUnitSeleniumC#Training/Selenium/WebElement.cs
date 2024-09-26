using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class WebElement
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            //launch chrome browser
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Testcase()
        {

            
            IWebElement table = driver.FindElement(By.XPath("//table[@name = 'courses']"));

            //Fetch all the rows of table

            List<IWebElement> tr = new List<IWebElement>(table.FindElements(By.XPath("//table[@name = 'courses']/tbody/tr")));
            int rowcount = tr.Count();
            Console.WriteLine(rowcount);

            //fetch no of columns
            List<IWebElement> td = new List<IWebElement>(table.FindElements(By.XPath("//table[@name = 'courses']/tbody/tr[8]/td")));
            int colcount = td.Count();
            Console.WriteLine(colcount);

            //cell data
            IWebElement celldata = driver.FindElement(By.XPath("//table[@name = 'courses']/tbody/tr[8]/td[2]"));
            String text = celldata.Text;
            Console.WriteLine(text);

            Assert.AreEqual("QA Expert Course :Software Testing + Bugzilla + SQL + Agile", text);


        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}