using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class DemoWebShop
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {

            Thread.Sleep(10000);
            //launch chrome browser
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement firstName = wait.Until(d => d.FindElement(By.Id("FirstName")));
            firstName.SendKeys("Maneesh");

            IWebElement lastName = driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("Shetty");

            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys("manee@gmail.com");

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("Password123");

            IWebElement confirmPassword = driver.FindElement(By.Id("ConfirmPassword"));
            confirmPassword.SendKeys("Password123");

            IWebElement registerButton = driver.FindElement(By.Id("register-button"));
            registerButton.Click();
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}

