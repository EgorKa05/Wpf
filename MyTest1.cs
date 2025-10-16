using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using WpfApp1;

namespace WpfApp1.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        // ==================== Метод трапеций ====================
        [TestMethod]
        public void Trapecia_Quadratic_ReturnsCorrectValue()
        {
            MyCalculator calculator = new Trapecia();
            Func<double, double> f = x => x * x;
            double expected = 9.0; // ∫0^3 x^2 dx

            double result = calculator.Calculate(0, 3, 10000, f);

            Assert.AreEqual(expected, result, 1e-4);
        }
    }
}
