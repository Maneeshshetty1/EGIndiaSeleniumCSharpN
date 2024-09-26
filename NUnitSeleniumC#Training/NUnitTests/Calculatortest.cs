using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTests
{
    internal class Calculatortest
    {
        Calculator cl = new Calculator();

        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);

            int result1 = cl.Add(3, -4);

            //Assertion on NUNIT to compare expected results with actual 

            Assert.AreEqual(5, result);

            Assert.AreEqual(-1, result1);

       
        }
        //Substraction
        [Test]
        public void SubTest()
        {
            int result = cl.Sub(9, 3);

            int result1 = cl.Sub(10, -4);

            //Assertion on NUNIT to compare expected results with actual 

            Assert.AreEqual(6, result);

            Assert.AreEqual(14, result1);
        }

        [Test]
        public void MulTest()
        {
            int result = cl.Mul(2, 3);

            int result1 = cl.Mul(4,2);

            //Assertion on NUNIT to compare expected results with actual 

            Assert.AreEqual(6, result);

            Assert.AreEqual(8, result1);
        }
    }
}
