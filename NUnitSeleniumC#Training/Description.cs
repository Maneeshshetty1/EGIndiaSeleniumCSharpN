using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training
{
    internal class Description
    {
        [Test]
        [Description("Testcase verifies the login functionality")]

        public void testcase1()
        {
            Console.WriteLine("This is the first testcase");
        }
    }
}
