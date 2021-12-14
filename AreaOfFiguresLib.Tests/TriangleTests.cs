using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaOfFiguresLib.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Test_positive()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            double result = triangle.Calculate();
            Assert.AreEqual(result, 6);
        }
        [TestMethod]
        public void Test_negative()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(-5, -5, -1);
            });
        }
        [TestMethod]
        public void Test_zero()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(0, 0, 0);
            });
        }
        [TestMethod]
        public void Test_TriangleRight()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            triangle.Calculate();
            bool isRight = triangle.IsTriangleRightChecking();
            Assert.IsTrue(isRight);
        }
        [TestMethod]
        public void Test_TriangleIsntRight()
        {
            Triangle triangle = new Triangle(6, 5, 4);
            triangle.Calculate();
            bool isRight = triangle.IsTriangleRightChecking();
            Assert.IsFalse(isRight);
        }
    }
}
