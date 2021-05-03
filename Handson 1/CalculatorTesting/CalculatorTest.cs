using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTesting
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        [TestCase(10,20,30)]
        public void CalculatorTestMethod(int numA,int numB,int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(numA, numB);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0, 50, 0)]
        public void CalculatorTestMethod2(int numA, int numB, int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(numA, numB);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
