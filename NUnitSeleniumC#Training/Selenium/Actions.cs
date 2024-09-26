using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions; // Add this for Actions class

namespace NUnitSeleniumC_Training.Selenium
{
    internal class SeleniumActions // Renamed to avoid conflict
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase1()
        {
            IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

            new Actions(driver)
              .DoubleClick(TdyDeal)
              .Perform();
            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDownChrome()
        {
            driver.Close();
        }
    }
}
