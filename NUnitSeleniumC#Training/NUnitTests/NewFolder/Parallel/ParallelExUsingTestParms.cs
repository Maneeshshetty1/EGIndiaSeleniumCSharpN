using NUnitSeleniumC_Training.Selenium;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTests.NewFolder.Parallel
{
   
    
        [Parallelizable]
        internal class ParallelExUsingTestParms : Base
        {


            [Parallelizable(ParallelScope.Children)]
            [Test, TestCaseSource("GetTestData")]
            public void LoginTest(string username, string password)
            {


                DateTime currentTime = DateTime.Now;
                string time = currentTime.ToString("yyyy-MM-dd-_HH-mm-ss");
                Console.WriteLine(username + ":" + password + "......." + time);
                Thread.Sleep(3000);

                // Find the element usibg the By class locators 
                IWebElement Username = driver.FindElement(By.Name("username"));
                // inputing text using send keys 
                Username.SendKeys(username);

                Thread.Sleep(1000);

                IWebElement Password = driver.FindElement(By.Name("password"));
                // inputing text using send keys 
                Password.SendKeys(password);


                IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
                LoginButton.Click();

                Thread.Sleep(1000);

                IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));

                string errmsg = Errmsg.Text;

                Console.WriteLine(errmsg);

                Assert.AreEqual("Invalid credentials", errmsg);


            }

            public static IEnumerable<TestCaseData> GetTestData()
            {

                yield return new TestCaseData("abc.com", "ghhjj");
                yield return new TestCaseData("ghh.com", "fghhj");
                yield return new TestCaseData("mkk.com", "ddffg");


            }

            [TearDown]
            public void TearDown()
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver = null;
                }
            }

        }
    }
