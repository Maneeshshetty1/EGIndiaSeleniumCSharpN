using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using AngleSharp;
using System.Configuration;

namespace NUnitSeleniumC_Training.Utilities
{
    public class Base
    {
       
            public IWebDriver driver;
            [SetUp]
            public void StartBrowser()
            {

                string browserName = ConfigurationManager.AppSettings["browser"];
                InitBrowser(browserName);
                // launch the chrome browser
                driver.Navigate().GoToUrl("https://www.selenium.dev/");
                driver.Manage().Window.Maximize();
            }


            public void InitBrowser(string browserName)
            {

                switch (browserName)
                {

                    case "Firefox":
                        // confifgure the web driver manager to set up the chrome capabilities
                        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                        // intialize the web driver 
                        driver = new FirefoxDriver();
                        break;

                    case "Chrome":
                        // confifgure the web driver manager to set up the chrome capabilities
                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        // intialize the web driver 
                        driver = new ChromeDriver();
                        break;

                    case "Edge":
                        // confifgure the web driver manager to set up the chrome capabilities
                        new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                        // intialize the web driver 
                        driver = new EdgeDriver();
                        break;


                }


            }


            [TearDown]
            public void tearDownbrowser()
            {


                driver.Close();
                driver.Quit();

            }
        }
    }