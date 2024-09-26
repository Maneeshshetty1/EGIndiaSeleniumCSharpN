using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTests
{
    [SetUpFixture]
    internal class OneTimeSetUpandTearDown
    {
        [OneTimeSetUp]
        public void dbconnectionopen()
        {


            Console.WriteLine("Opening the DB connection");
        }
        [OneTimeTearDown]
        public void dbconnectionclose()
        {
            Console.WriteLine("Closing the DB Connection");
        }
    }
}