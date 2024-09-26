using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTests
{
    internal class CalculatorUnitTesting
    {
        Calculator cl =new Calculator();
        

        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);

            int result1 = cl.Add(3, -4);

            //Assertion
            Assert.AreEqual(5, result);

            Assert.AreEqual(-1, result1);
        }
        [Test]
        public void SubTest()
        {
            int result = cl.Sub(4, 3);



            //Assertion
            Assert.AreEqual(1, result);

        }
    }
}
