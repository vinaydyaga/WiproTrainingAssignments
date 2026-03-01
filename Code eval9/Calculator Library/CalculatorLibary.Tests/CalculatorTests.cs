using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorLibary.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            double result = _calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Subtract_ReturnsCorrectResult()
        {
            double result= _calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void Multiply_ReturnsCorrectResult()
        {
            double result = _calculator.Multipy(4, 5);
            Assert.AreEqual(20, result);
        }
        [Test]
        public void Divide_ReturnsCorrectResult()
        {
            double result = _calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroExeception>(()=>_calculator.Divide(10,0));
        }
        [Test]
        public void Add_WithZero_ReturnsSameNumber()
        {
            double result=_calculator.Add(5, 0);
            Assert.AreEqual(5, result);
        }
    }
}
