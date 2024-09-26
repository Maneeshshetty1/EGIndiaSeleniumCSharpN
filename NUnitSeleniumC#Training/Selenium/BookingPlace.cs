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
    internal class BookingPlace
    {
        IWebDriver driver;

        [SetUp]
        public void StartChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html?aid=2369661&pagename=en-in-booking-desktop&label=msn-HiTydpHndf_KligNqm9Sgw-79852220055838:tikwd-79852393960302:loc-90:neo:mte:lp116072:dec:qsBooking.com)&utm_campaign=English_India%20EN%20IN&utm_medium=cpc&utm_source=bing&utm_term=HiTydpHndf_KligNqm9Sgw&msclkid=576d951af0441a9cdb5bf3f79ce6dbdd&utm_content=Booking%20-%20Desktop");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {



            IWebElement destinationInput = driver.FindElement(By.Id("ss"));
            destinationInput.SendKeys("Goa");
            IWebElement checkInDate = driver.FindElement(By.XPath("input[data-placeholder='Check-in Date']"));
            checkInDate.Click();
            IWebElement selectCheckInDate = driver.FindElement(By.XPath("td[data-date='2024-10-01']"));
            selectCheckInDate.Click();

            

            // Select number of guests
            IWebElement guestsInput = driver.FindElement(By.Id("xp__guests__toggle"));
            guestsInput.Click();
            IWebElement addAdult = driver.FindElement(By.XPath("button[aria-label='Increase number of Adults']"));
            addAdult.Click();

            // Click search button
            IWebElement searchButton = driver.FindElement(By.XPath("button[type='submit']"));
            searchButton.Click();

            // Validate search results
            Assert.IsTrue(driver.FindElement(By.XPath("div.sr_header")).Displayed, "Search results are not displayed");

            // Validate promotional banners
            IWebElement promoBanner = driver.FindElement(By.XPath("div.promo-banner"));
            Assert.IsTrue(promoBanner.Displayed, "Promotional banner is not displayed");
        




    }

            [TearDown]
            public void tearDownChrome()
            {
                driver.Close();
            }
        }
    }

