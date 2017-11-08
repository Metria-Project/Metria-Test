using Metria.Hyperbolic._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Metria_Test
{
    [TestClass]
    public class _2_hyperbolic_point
    {
        [TestMethod]
        public void euclidian_distance_1()
        {
            Point P = new Point();
            Assert.AreEqual(P.EuclidianDistance(new Point(0, 1)), 1);
        }
        [TestMethod]
        public void euclidian_distance_2()
        {
            Point P = new Point();
            Assert.AreEqual(P.EuclidianDistance(new Point()), 0);
        }
        [TestMethod]
        public void euclidian_distance_3()
        {
            Point P = new Point();
            Assert.AreEqual(P.EuclidianDistance(new Point(1, 1)), Math.Sqrt(2));
        }

        [TestMethod]
        public void euclidian_powered_distance_1()
        {
            Point P = new Point();
            Assert.AreEqual(P.EuclidianPoweredDistance(new Point()), 0);
        }

        [TestMethod]
        public void euclidian_powered_distance_2()
        {
            Point P = new Point();
            Assert.AreEqual(P.EuclidianPoweredDistance(new Point(1,1)), 2);
        }

        [TestMethod]
        public void euclidian_powered_distance_2()
        {
            Point P = new Point();
	    Asser.AreEqual(P.EuclidianPoweredDistance(new Point(0,10),100);
        }

    }
}
