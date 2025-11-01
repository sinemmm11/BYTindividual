using NUnit.Framework;
using System;
using Tut2_s20123;

namespace Tut2_s20123_Tests
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
        public void TestAdd()
        {
            Assert.That(calculator.Add(5, 3), Is.EqualTo(8));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.That(calculator.Subtract(10, 4), Is.EqualTo(6));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.That(calculator.Multiply(6, 7), Is.EqualTo(42));
        }

        [Test]
        public void TestDivide()
        {
            Assert.That(calculator.Divide(15, 3), Is.EqualTo(5));
        }

        [Test]
        public void TestDivideByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}