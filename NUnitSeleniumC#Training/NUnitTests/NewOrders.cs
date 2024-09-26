using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTests
{
    internal class NewOrders
    {
        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("login");
        }
        [Test, Order(2)]
        public void product()
        {
            Console.WriteLine("Selecting the Products");
        }

        [Test, Order(3)]
        public void addcart()
        {
            Console.WriteLine("Product added to the cart");
        }
    }
}