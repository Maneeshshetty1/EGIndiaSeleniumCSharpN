using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUnitTests
{
    [Allure.NUnit.AllureNUnit]

    internal class Calculator
    {
        //Addition operation
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        //substraction
        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }
        //Division

        public int Div(int a, int b)
        {
            int c = a / b;
            return c;
        }

        //Multiflication

        public int Mul(int a, int b)
        {
            int c = a * b;
            return c;
        }

    }
}
