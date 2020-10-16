using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;
   

namespace Lab_3_Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CreateEmpty()
        {
            TCircle test = new TCircle();
            Assert.AreEqual(1, test.Radius, "Empty constructor don't work");
        }

        [TestMethod]
        public void CopyConstruct()
        {
            TCircle circle = new TCircle(15);
            TCircle circle2 = new TCircle(circle);
            Assert.AreEqual(circle.Radius, circle2.Radius, "Copy constructor don't work");
        }

        [TestMethod]
        public void DoubleConstruct()
        {
            TCircle circle = new TCircle(7.49);
            Assert.AreEqual(7.49, circle.Radius, "Double constructor don't work");
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new TCircle(-7));
        }

        [TestMethod]
        public void SquareAndCircuit()
        {
            TCircle circle = new TCircle(7);
            Assert.AreEqual(Math.PI * Math.Pow(7, 2), circle.GetSquare(), "GetSquare don't work");
            Assert.AreEqual(2 * Math.PI * 7, circle.GetCircuit(), "GetCircuit don't work");
        }

        [TestMethod]
        public void Comparison()
        {
            TCircle circle = new TCircle(7);
            TCircle circle2 = new TCircle(9);
            Assert.AreEqual(true, circle < circle2, "operator '<' don't work");
            Assert.AreEqual(false, circle > circle2, "operator '>' don't work");
            Assert.AreEqual(false, circle == circle2, "operator '==' don't work");
            Assert.AreEqual(true, circle != circle2, "operator '!=' don't work");
        }
    }
}
