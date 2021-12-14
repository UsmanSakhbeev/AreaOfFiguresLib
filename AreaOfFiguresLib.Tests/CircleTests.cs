using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaOfFiguresLib.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Test_positive()
        {
            Circle circle = new Circle(5);
            double result = circle.Calculate();
            Assert.AreEqual(result, 31.400, 0.01);
        }
        [TestMethod]
        public void Test_zero()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Circle circle = new Circle(0);
            });
        }
        [TestMethod]
        public void Test_negative()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Circle circle = new Circle(-5);
            });
        }
    }
}
