using Metria.Hyperbolic._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Metria_Test
{
    [TestClass]
    public class _2_hyperbolic_ray
    {
        #region Clone
        
        [TestMethod]
        public void clone_1()
        {
            Point a = new Point(3,0), b = new Point(9,4);
            Ray _base = new Ray(a, b);
            Assert.AreEqual(_base.Clone() as Ray, _base );
        }

        [TestMethod]
        public void clone_2()
        {
            Point a = new Point(7,1), b = new Point(7,9);
            Ray _base = new Ray(a, b);
            Assert.AreEqual(_base.Clone() as Ray, _base );
        }

        #endregion   
    }
}