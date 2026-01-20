using NUnit.Framework;
using CalculatorApp;
using System;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ValidNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(15, _calculator.Add(10, 5));
        }

        [Test]
        public void Subtract_ValidNumbers_ReturnsCorrectDifference()
        {
            Assert.AreEqual(7, _calculator.Subtract(10, 3));
        }

        [Test]
        public void Multiply_ValidNumbers_ReturnsCorrectProduct()
        {
            Assert.AreEqual(20, _calculator.Multiply(4, 5));
        }

        [Test]
        public void Divide_ValidNumbers_ReturnsCorrectQuotient()
        {
            Assert.AreEqual(5, _calculator.Divide(20, 4));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
