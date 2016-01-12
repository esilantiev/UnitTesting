using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            Calculator calc = new Calculator();

            var result = calc.Sum();

            Assert.AreEqual(0, result);
        }

        public void Add_WhenCalled_ChagesSum()
        {
            Calculator calc = MakeCalc();

            calc.Add(1);
            var sum = calc.Sum();

            Assert.AreEqual(1, sum);
        }

        public static Calculator MakeCalc()
        {
            return new Calculator();
        }
    }
}
