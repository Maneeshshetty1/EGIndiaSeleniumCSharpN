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
    internal class WindowHandling
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            // fetch the handle of the parent page

            string currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            // click on the link to open the new window

            IWebElement Open = driver.FindElement(By.XPath("//a[@id='a-link-that-opens-a-new-window']"));
            Open.Click();

            // fetch the window handles of all windows there will be two windows opened

            IList<string> windowHandles = new List<string>(driver.WindowHandles);

            // the control is moved to child window

            driver.SwitchTo().Window(windowHandles[1]);

            string title = driver.Title;

            Console.WriteLine(title);

            Assert.AreEqual("Simple Page", title);

            // closing of the child window

            driver.Close();

            Thread.Sleep(3000);

            driver.SwitchTo().Window(windowHandles[0]);


            string title1 = driver.Title;

            Console.WriteLine(title1);

            Assert.AreEqual("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow", title1);




        }

        [TearDown]
        public void tearDownChrome()
        {
            driver.Close();
        }
    }
}
