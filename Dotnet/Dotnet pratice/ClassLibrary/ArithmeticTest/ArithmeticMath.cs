using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;

namespace ArithmeticTest
{
    [TestClass]
    public class ArithmeticMath
    {
        [TestMethod]
        public void Add_Test()
        {

            Arithmetic at = new Arithmetic();
         
            int? resultActual = at.Add(3, 5);
            Assert.AreEqual(resultActual, 8);
            int? resultNullInput = at.Add(null, 5);
            Assert.IsNull(resultNullInput);
            int? resultBothNull = at.Add(null, null);
            Assert.IsNull(resultBothNull);
        }

        [TestMethod]
        public void Subtract_Test()
        {
            Arithmetic at = new Arithmetic();
            int? resultActual = at.Subtract(10, 5);
            Assert.AreEqual(resultActual, 5);
            int? resultNullInput = at.Subtract(null, 5);
            Assert.IsNull(resultNullInput);
            int? resultBothNull = at.Subtract(null, null);
            Assert.IsNull(resultBothNull);
        }

        [TestMethod]
        public void Multiply_Test()
        {
         
            Arithmetic at = new Arithmetic();
            int? resultActual = at.Multiply(3, 5);
            Assert.AreEqual(resultActual, 15);
            int? resultNullInput = at.Multiply(null, 5);
            Assert.IsNull(resultNullInput);
            int? resultBothNull = at.Multiply(null, null);
            Assert.IsNull(resultBothNull);
        }

        [TestMethod]
        public void Square_Test()
        {
            Arithmetic at = new Arithmetic();
            int? resultActual = at.Square(3);
            Assert.AreEqual(resultActual, 9);
            int? resultNullInput = at.Square(null);
            Assert.IsNull(resultNullInput);
        }
    }
}
