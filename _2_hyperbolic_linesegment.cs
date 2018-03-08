using Metria.Hyperbolic._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Metria_Test
{
    [TestClass]
    public class _2_hyperbolic_linesegment
    {
        #region Constructor
        
        [TestMethod]
        public void _53()
        {
            Point a = new Point(5,1), b = new Point(5,5);
            LineSegment _base = new LineSegment(a, b);
            Assert.AreEqual(_base.A == new Point(5,1)
			   && _base.B == new Point(5,5), true);
        }
        
        [TestMethod]
        public void _54()
        {
            Point a = new Point(7,7), b = new Point(7,5);
            LineSegment _base = new LineSegment(a, b);
            Assert.AreEqual(_base.A == new Point(7,5) 
			    && _base.B == new Point(7,7), true);
        }
        
        [TestMethod]
        public void _55()
        {
            Point a = new Point(0,0), b = new Point(4,0);
            bool passou = false;
            try
            {
                LineSegment _base = new LineSegment(a, b);
            }
            catch
            {
                passou = true;
            }
            Assert.IsTrue(passou);
        }
        
        [TestMethod]
        public void _56()
        {
            Point a = new Point(7,6), b = new Point(2,3);
            LineSegment _base = new LineSegment(a, b);
            Assert.AreEqual(_base.A == new Point(2,3) 
			    && _base.B == new Point(7,6), true);
        }
        
        [TestMethod]
        public void constructor_5()
        {
            Point a = new Point(2,3), b = new Point(7,6);
            LineSegment _base = new LineSegment(a, b);
            Assert.AreEqual(_base.A == new Point(2, 3) 
			    && _base.B == new Point(7, 6), true);
        }

        #endregion
        #region Clone

        [TestMethod]
        public void _57()
       {
            Point a = new Point(0,1), b = new Point(3,2);
            LineSegment l = new LineSegment(a, b);
            LineSegment c = l.Clone() as LineSegment;
            Assert.AreEqual(l, c);
        }

        [TestMethod]
        public void _58()
        {
            Point a = new Point(2,1), b = new Point(2,9);
            LineSegment l = new LineSegment(a, b);
            LineSegment c = l.Clone() as LineSegment;
            Assert.AreEqual(l,c);
        }

        #endregion
        #region Zoom

        [TestMethod]
        public void _60()
        {
            Point a = new Point(3,8), b = new Point(3,2);
            LineSegment _base = new LineSegment(a, b);
            Assert.AreEqual(_base.Zoom(5), new LineSegment(
                new Point(15,40), new Point(15, 10)));
        }

        [TestMethod]
        public void _61()
        {
            Point a = new Point(2,6), b = new Point(7,3);
            LineSegment _base = new LineSegment(a, b);
            Assert.AreEqual(_base.Zoom(4), new LineSegment(
                new Point(8,24), new Point(28, 12)));
        }

        #endregion     
        #region Belongs
        
        [TestMethod]
        public void _64()
        {
	    //infinity
            Point a = new Point(-1,Math.Sqrt(24)), b = new Point(1,Math.Sqrt(24));
            LineSegment l = new LineSegment(a, b);
            Point p = new Point(0, 5);
            Assert.AreEqual(true,l.Belongs(p));
        }
        
        [TestMethod]
        public void _65()
        {
            Point a = new Point(0,19), b = new Point(0,5);
            LineSegment l = new LineSegment(a, b);
            Point p = new Point(0, 4);
            Assert.AreEqual(l.Belongs(p), false);
        }
        
        [TestMethod]
        public void _66()
        {
            Point a = new Point(0,19), b = new Point(0,5);
            LineSegment _base = new LineSegment(a, b);
            Point t = new Point(0, 21);
            Assert.AreEqual(false, _base.Belongs(a));
        }
        
        [TestMethod]
        public void _67()
        {
            Point a = new Point(0,5), b = new Point(0,19);
            LineSegment _base = new LineSegment(a, b);
            Point t = new Point(1, 17);
            Assert.AreEqual(_base.Belongs(t), false);
        }
        
        [TestMethod]
        public void belongs_5()
        {
            Point a = new Point(-4, 5), b = new Point(4, 5);
            LineSegment _base = new LineSegment(a, b);
            Point t = new Point(0, 6);
            Assert.AreEqual(_base.Belongs(t), false);
        }
        
        [TestMethod]
        public void belongs_6()
        {
            Point a = new Point(-1, 5), b = new Point(1, 5);
            LineSegment _base = new LineSegment(a, b);
            Point t = new Point(-2, 6);
            Assert.AreEqual(_base.Belongs(t), false);
        }
        
        [TestMethod]
        public void belongs_7()
        {
            Point a = new Point(-1,5), b = new Point(1,5);
            LineSegment _base = new LineSegment(a, b);
            Point t = new Point(2, 5);
            Assert.AreEqual(_base.Belongs(t), false);
        }
        
        [TestMethod]
        public void belongs_8()
        {
            Point a = new Point(-1,5), b = new Point(1,5);
            LineSegment _base = new LineSegment(a, b);
            Point t = new Point(0, 7);
            Assert.AreEqual(_base.Belongs(t), false);
        }
        
        [TestMethod]
        public void belongs_9()
        {
            Point a = new Point(-1,5), b = new Point(1,5);
            LineSegment _base = new LineSegment(a, b);
            Point t = new Point(0, 5);
            Assert.AreEqual(_base.Belongs(t), false);
        }
        #endregion
        #region Intersection Point

        [TestMethod]
        public void instersection_point_1()
        {
            LineSegment _base = new LineSegment(new Point(0.4, 0.8)
                , new Point(1.6, 0.8));
            Line cut = new Line( new Point(1,0), new Point(1,1));
            Point ret = new Point(1, 1);
            Assert.AreEqual(_base.IntersectionPoint(cut), ret);
        }
        
        [TestMethod]
        public void instersection_point_2()
        {
            LineSegment _base = new LineSegment(new Point(4.2, 0.4)
                , new Point(5.8, 0.4));
            Line cut = new Line( new Point(3,0), new Point(5,0));
            Point ret = new Point(4.6, 0.8);
            Assert.AreEqual(_base.IntersectionPoint(cut), ret);
        }
        
        [TestMethod]
        public void instersection_point_3()
        {
            LineSegment _base = new LineSegment( new Point(0,0)
                , new Point(2,0));
            Line cut = new Line( new Point(1,0), new Point(0,0));
            bool passou = false;
            try
            {
                Point ret = new Point(1, 1);
            }
            catch
            {
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }
        
        [TestMethod]
        public void instersection_point_4()
        {
            LineSegment _base = new LineSegment( new Point(0.3,0.9)
                , new Point(2.7,0.9));
            Line cut = new Line( new Point(5,0), new Point(12,0));
            Assert.AreEqual(
                object.ReferenceEquals(_base.IntersectionPoint(cut), null)
                , true);
        }
        
        [TestMethod]
        public void instersection_point_5()
        {
            LineSegment _base = new LineSegment( new Point(0.3,0.9)
                , new Point(2.7,0.9));
            Line cut = new Line( new Point(5,0), new Point(5,1));
            Assert.AreEqual(
                object.ReferenceEquals(_base.IntersectionPoint(cut), null)
                , true);
        }
        #endregion
    }
}
