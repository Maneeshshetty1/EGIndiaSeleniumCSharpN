using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class SauceDemo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            // Configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // Initialize web driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Run()
        {
            Thread.Sleep(2000);
            // Login
            IWebElement Username = driver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            IWebElement LoginButton = driver.FindElement(By.Name("login-button"));
            LoginButton.Click();
            Thread.Sleep(2000);
            // Add to cart
            System.Threading.Thread.Sleep(5000); // Wait for the page to load
            IWebElement AddToCartButton = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            AddToCartButton.Click();

            // Navigate to cart
            IWebElement CartLink = driver.FindElement(By.ClassName("shopping_cart_link"));
            CartLink.Click();

            // Proceed to checkout
            System.Threading.Thread.Sleep(5000); // Wait for the page to load
            IWebElement CheckoutButton = driver.FindElement(By.Id("checkout"));
            CheckoutButton.Click();

            // Fill in checkout information
            IWebElement FirstName = driver.FindElement(By.Id("first-name"));
            FirstName.SendKeys("John");

            IWebElement LastName = driver.FindElement(By.Id("last-name"));
            LastName.SendKeys("Doe");

            IWebElement PostalCode = driver.FindElement(By.Id("postal-code"));
            PostalCode.SendKeys("12345");

            IWebElement ContinueButton = driver.FindElement(By.Id("continue"));
            ContinueButton.Click();

            // Complete the order
            System.Threading.Thread.Sleep(5000); // Wait for the page to load
            IWebElement FinishButton = driver.FindElement(By.Id("finish"));
            FinishButton.Click();

            // Verify order completion
            IWebElement OrderConfirmation = driver.FindElement(By.ClassName("complete-header"));
            Assert.IsTrue(OrderConfirmation.Displayed, "Order was not completed successfully.");

            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
