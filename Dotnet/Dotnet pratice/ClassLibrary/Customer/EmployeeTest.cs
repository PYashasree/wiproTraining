

using System;
using NUnit.Framework;

namespace ArithmeticLibrary
{
    [TestFixture]
    public class ArithmeticOperationsTests
    {
        private ArithmeticOperations _arithmetic;

        [SetUp]
        public void Setup()
        {
            // This method is called before each test
            _arithmetic = new ArithmeticOperations();
        }

        [TearDown]
        public void Teardown()
        {
            // This method is called after each test
            _arithmetic = null;
        }

        [Test]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _arithmetic.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _arithmetic.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_ShouldReturnProductOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _arithmetic.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Divide_ShouldReturnQuotientOfTwoNumbers()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            double result = _arithmetic.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(2.0));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            // Arrange
            int a = 6;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _arithmetic.Divide(a, b));
        }
    }
}

