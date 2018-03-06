using Metria.Hyperbolic._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Metria_Test
{
    [TestClass]
    public class _2_hyperbolic_point
    {
        #region Euclidian Distance
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
        public void euclidian_distance_4()
        {
            Point P = new Point(2,5);
            Assert.AreEqual(P.EuclidianDistance(new Point(0, 6)), Math.Sqrt(5));
        }
        [TestMethod]
        public void euclidian_distance_5()
        {
            Point P = new Point(1,8);
            Assert.AreEqual(P.EuclidianDistance(new Point(4,6)), Math.Sqrt(13));
        }
        [TestMethod]
        public void euclidian_distance_6()
        {
            Point P = new Point(3,2);
            Assert.AreEqual(P.EuclidianDistance(new Point(3,2)), 0);
        }
        [TestMethod]
        public void euclidian_distance_7()
        {
            Point P = new Point();
            Assert.AreEqual(P.EuclidianDistance(new Point(0, 5)), 5);
        }
        #endregion
        #region Euclidian Powered Distance
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
        public void euclidian_powered_distance_3()
        {
            Point P = new Point();
	        Assert.AreEqual(P.EuclidianPoweredDistance(new Point(0,10)),100);
        }
        [TestMethod]
        public void euclidian_powered_distance_4()
        {
            Point P = new Point(2,5);
	        Assert.AreEqual(P.EuclidianPoweredDistance(new Point(0,6)),5);
        }
        [TestMethod]
        public void euclidian_powered_distance_5()
        {
            Point P = new Point(3,2);
	        Assert.AreEqual(P.EuclidianPoweredDistance(new Point(3,2)),0);
        }
        [TestMethod]
        public void euclidian_powered_distance_6()
        {
            Point P = new Point();
	        Assert.AreEqual(P.EuclidianPoweredDistance(new Point(0,5)),25);
        }
        #endregion

    }
}
