using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureNUnit
    {
        
        [Test, Category("Login")]
        public void login()
        {
            Console.WriteLine("login");
        }
        [Test, Category("Sanity")]
        public void product()
        {
            Console.WriteLine("Selecting the Products");
        }

        [Test, Category("Regression")]
        public void addcart()
        {
            Console.WriteLine("Product added to the cart");
        }


        
    }
}
