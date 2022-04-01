using AreaOfFiguresLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaOfFiguresTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Area()
        {
            var circle = new CircleFigure(5);
            Assert.AreEqual(circle.Area, 78.54, 0.01);
        }

        [TestMethod]
        public void IsRadiusZero()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var circle = new CircleFigure(0);
            });
        }

        [TestMethod]
        public void IsRadiusNegative()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var circle = new CircleFigure(-5);
            });
        }
    }
}