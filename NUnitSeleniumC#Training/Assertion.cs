using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training
{
    internal class Assertion
    {
        [Test]
        public void testassertion()
        {
            string actual = "Google";
            string expected = "Chrome";

           if (actual == expected)
            {
                Console.WriteLine("The results are matching");
            }
            else
            {
                Console.WriteLine("The results not matching");
            }

            /*Assert.AreEqual(actual, expected);
            Assert.AreNotEqual(actual, expected);


            //Assert that
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.Not.EqualTo(expected));

            //assert for ignore case
            Assert.That(actual,Is.EqualTo(expected).IgnoreCase);

            //collection constraint
            int[] array=new int[] { 1, 2, 3 };*/
        }
    }
}

