using AreaOfFiguresLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaOfFiguresTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IsSidesPositive()
        {
            var triangle = new TriangleFigure(5, 4, 3);
            Assert.AreEqual(triangle.Area, 6);
        }

        [TestMethod]
        public void IsntExist()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var triangle = new TriangleFigure(5, 1, 3);
            });
        }

        [TestMethod]
        public void IsSidesIsntPositive()
        {
            IsSideIsntPositive(0, 4, 3);
            IsSideIsntPositive(5, 0, 3);
            IsSideIsntPositive(5, 4, -1);
        }

        [TestMethod]
        public void IsRight()
        {
            var triangle = new TriangleFigure(5, 4, 3);
            Assert.IsTrue(triangle.IsRight);
        }

        [TestMethod]
        public void IsntRight()
        {
            var triangle = new TriangleFigure(5, 4, 2);
            Assert.IsFalse(triangle.IsRight);
        }

        private void IsSideIsntPositive(float a, float b, float c)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var triangle = new TriangleFigure(a, b, c);
            });
        }
    }
}