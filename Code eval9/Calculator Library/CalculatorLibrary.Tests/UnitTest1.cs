using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_Test()
        {
            Assert.That(calculator.Add(5, 3), Is.EqualTo(8));
        }

        [Test]
        public void Subtract_Test()
        {
            Assert.That(calculator.Subtract(10, 4), Is.EqualTo(6));
        }

        [Test]
        public void Multiply_Test()
        {
            Assert.That(calculator.Multiply(4, 5), Is.EqualTo(20));
        }

        [Test]
        public void Divide_Test()
        {
            Assert.That(calculator.Divide(10, 2), Is.EqualTo(5));
        }

        [Test]
        public void Divide_ByZero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
        [Test]
        public void Add_WithZero_ReturnsSameNumber()
        {
            Assert.That(calculator.Add(5, 0), Is.EqualTo(5));
        }

        [Test]
        public void Subtract_WithZero_ReturnsSameNumber()
        {
            Assert.That(calculator.Subtract(5, 0), Is.EqualTo(5));
        }

        [Test]
        public void Multiply_WithZero_ReturnsZero()
        {
            Assert.That(calculator.Multiply(5, 0), Is.EqualTo(0));
        }
    }
}