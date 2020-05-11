using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
namespace Geometry.Test
{
    [TestClass]
    public class PlanimetryTests
    {
        [TestMethod]
        public void Circle_r1_returnPi()
        {
            int radius = 1;
            double expected = Math.PI;

            double actual = Planimetry.Circle(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_3_4_5_return6()
        {
            double oneS = 3;
            double twoS = 4;
            double threeS = 5;
            double expected = 6;

            double actual = Planimetry.Triangle(oneS, twoS, threeS);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsRightTriangle_3_4_6_isFail()
        {
            Assert.IsFalse(Planimetry.IsRightTriagle(3, 4, 6));
        }

        [TestMethod]
        public void UnknowFigure_1_2_3_4_returnMinus1()
        {
            int oneS = 1;
            int twoS = 2;
            int threeS = 3;
            int fourS = 4;

            int expected = -1;

            double actual = Planimetry.UnknowFigure(oneS, twoS, threeS, fourS);

            Assert.AreEqual(expected, actual);
        }
            
    }
}
