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
    }
}
