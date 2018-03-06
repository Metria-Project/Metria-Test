using Metria.Hyperbolic._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Metria_Test
{
    [TestClass]
    public class _2_hyperbolic_line
    {
        #region fix_values
        //To test fix values we just need to intantiate the line
        [TestMethod]
        public void _1()//FIX Split into more tests
        {
            Line l = new Line(new Point(2, 1), new Point(2, 2));
            Point ponta = new Point(2, 0);
            Assert.AreEqual(l.A.X == 2 && l.B.X == 2 && l.Center == l.Alfa && 
                            l.Center==l.Beta&&l.Center==ponta&& Math.Abs(l.Radius) < Base.Epslon
                            , true);
        }
        
        [TestMethod]
        public void _2()
        {
            Point a = new Point(2, 0), b = new Point(2, 6);
            Line l = new Line(a, b);
            Assert.AreEqual(l.A == a && l.B == b, true);
        }
        
        [TestMethod]
        public void _3()
        {
            Point a = new Point(2, 9), b = new Point(2, 6);
            Line l = new Line(a, b);
            Assert.AreEqual( l.A == b && l.B == a, true);
        }

        [TestMethod]
        public void _4()
        {
            Point a = new Point(2, 0), b = new Point(6, 0);
            Line l = new Line(a, b);
            Assert.AreEqual(l.Center == new Point(4, 0) && Math.Abs(l.Radius - 2) < Base.Epslon &&
                            l.Alfa == new Point(2, 0) &&
                            l.Beta == new Point(6, 0), true );
        }

        [TestMethod]
        public void _5()
        {
            Point a = new Point(1, 2), b = new Point(2, Math.Sqrt(3));
            Line l = new Line(a, b);
            Assert.AreEqual(l.Center == new Point(1, 0) && Math.Abs(l.Radius - 2)<Base.Epslon &&
                            l.Alfa == new Point(-1, 0) &&
                            l.Beta == new Point(3, 0), true );
        }

        [TestMethod]
        public void _6()
        {
            Point a = new Point(2, Math.Sqrt(3)), b = new Point(1, 2);
            Line l = new Line(a, b);
            Assert.AreEqual(l.A == b && l.B == a, true );
        }
        [TestMethod]
        public void fix_values_7()
        {
            Point a = new Point(2, 5), b = new Point(2, 2);
            Line l = new Line(a, b);
            Assert.AreEqual(l.Alfa == l.Beta && l.Beta == l.Center
            && l.Center == new Point(2,0) && Math.Abs(l.Radius) < Base.Epslon
            && l.A == b && l.B == a, true );
        }
        [TestMethod]
        public void fix_values_8()
        {
            Point a = new Point(3, 4), b = new Point(3, 7);
            Line l = new Line(a, b);
            Assert.AreEqual(l.Alfa == l.Beta && l.Beta == l.Center
            && l.Center == new Point(3,0) && Math.Abs(l.Radius) < Base.Epslon
            && l.A == a && l.B == b, true );
        }
        [TestMethod]
        public void fix_values_9()//ciro errou aqui
        {
            Point a = new Point(4, 3), b = new Point(5, 2 * Math.Sqrt(3));
            Line l = new Line(a, b);
            Assert.AreEqual(l.Alfa == new Point(1,0) && l.Beta == new Point(7,0)
            && l.Center == new Point(4,0) && Math.Abs(l.Radius - 3) < Base.Epslon && l.A == a 
            && l.B == b, true );
        }
        [TestMethod]
        public void fix_values_10()
        {
            Point a = new Point(2, 4), b = new Point(0, 2 * Math.Sqrt(3));
            Line l = new Line(a, b);
            Assert.AreEqual(l.Alfa == new Point(-2,0) && l.Beta == new Point(6,0)
            && l.Center == new Point(2,0) && Math.Abs(l.Radius - 3) < Base.Epslon && l.A == b 
            && l.B == a, true );
        }
        [TestMethod]
        public void fix_values_11()
        {
            Point a = new Point(-3, 0), b = new Point(-9, 0);
            Line l = new Line(a, b);
            Assert.AreEqual(l.Alfa == new Point(-2,0) && l.Beta == new Point(6,0)
            && l.Center == new Point(6,0) && l.Radius == 2 && l.A == b
            && l.B == a, true );
        }
        #endregion
        #region Intersction Point
        [TestMethod]
        public void _7()
        {
            Line l = new Line(new Point(1, 0), new Point(2, 0));
            Line t = new Line(new Point(1, 0), new Point(2, 0));
            bool levantou = false;
            try//Trocar pelo asset correto
            {
                Point p = l.IntersectionPoint(t);
            }
            catch
            {
                levantou = true;
            }
            Assert.AreEqual(true,levantou);
        }

        [TestMethod]
        public void _8()
        {
            Line l = new Line(new Point(1, 0), new Point(1, 1))
            , t = new Line(new Point(2, 0), new Point(2, 1));
            Point p = l.IntersectionPoint(t);
            Assert.AreEqual(p, null);
        }
        [TestMethod]
        public void _9()
        {
            Line l = new Line(new Point(1, 0), new Point(1, 1))
            , t = new Line(new Point(0, 0), new Point(2, 0));
            Point p = l.IntersectionPoint(t)
            , esperado = new Point(1,1);
            Assert.AreEqual(p,esperado);
        }
        [TestMethod]
        public void _10()
        {
            Line t = new Line(new Point(1, 0), new Point(1, 1))
            , l = new Line(new Point(1, 0), new Point(2, 0));
            Point p = l.IntersectionPoint(t)
            , esperado = new Point(1,0);
            Assert.AreEqual(esperado,p);
        }
        [TestMethod]
        public void _11()
        {
            Line l = new Line(new Point(1, 0), new Point(1, 1))
            , t = new Line(new Point(2, 0), new Point(3, 0));
            Point p = l.IntersectionPoint(t);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void _12()
        {
            Line l = new Line(new Point(1, 0), new Point(1, 1))
            , m = new Line(new Point(0, 0), new Point(2, 0));
            Point p = l.IntersectionPoint(m)
            , esperado = new Point(1,1);
            Assert.AreEqual(p,esperado);
        }
        [TestMethod]
        public void _13()
        {
            Line t = new Line(new Point(1, 0), new Point(1, 1))
            , l = new Line(new Point(1, 0), new Point(2, 0));
            Point p = l.IntersectionPoint(t)
            , esperado = new Point(1,0);
            Assert.AreEqual(p,esperado);
        }
        [TestMethod]
        public void _14()
        {
            Line t = new Line(new Point(1, 0), new Point(1, 1))
            , l = new Line(new Point(2, 0), new Point(3, 0));
            Point p = l.IntersectionPoint(t);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void _15()
        {
            Line t = new Line(new Point(0, 0), new Point(2, 0))
            , l = new Line(new Point(2, 0), new Point(4, 0));
            Point p = l.IntersectionPoint(t)
            , esperado = new Point(2,0);
            Assert.AreEqual(p,esperado);
        }
        [TestMethod]
        public void _16()
        {
            double a = 1.0 / 2;
            double b = Math.Sqrt(3.0 / 4);
            Point temp = new Point(a,b);
            Line t = new Line(new Point(-1, 0), new Point(1, 0))
            , l = new Line(new Point(0, 0), new Point(2, 0));
            Point p = l.IntersectionPoint(t);
            Assert.AreEqual(temp, p);
        }
        [TestMethod]
        public void _17()
        {
            Line m = new Line(new Point(0, 0), new Point(23, 0))
            , l = new Line(new Point(23, 0), new Point(24, 0));
            Point p = l.IntersectionPoint(m)
            , esperado = new Point(23,0);
            Assert.AreEqual(p,esperado);
        }
        [TestMethod]
        public void _18()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0))
            , t = new Line(new Point(0, 0), new Point(2, 0));
            Point p = l.IntersectionPoint(t)
            , esperado = new Point(1.0/2,Math.Sqrt(3.0/4));
            Assert.AreEqual(esperado,p);
        }
        [TestMethod]
        public void _19()
        {
            Line t = new Line(new Point(0, 0), new Point(2, 0))
            , l = new Line(new Point(3, 0), new Point(4, 0));
            Point p = l.IntersectionPoint(t);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void _20()
        {
            Line t = new Line(new Point(4, 0), new Point(6, 0))
            , l = new Line(new Point(-3, 0), new Point(-1, 0));
            Point p = l.IntersectionPoint(t);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void _21()
        {
            Line t = new Line(new Point(-5, 0), new Point(5, 0))
            , l = new Line(new Point(-1, 0), new Point(1, 0));
            Point p = l.IntersectionPoint(t);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void _22()
        {
            Line t = new Line(new Point(-2, 0), new Point(1, 0))
            , l = new Line(new Point(-4, 0), new Point(-3, 0));
            Point p = l.IntersectionPoint(t);
            Assert.IsNull(p);
        }
        [TestMethod]
        public void instersection_point_17()
        {
            Line l = new Line(new Point(-3, 0), new Point(-9, 0)),
            m = new Line(new Point(-9,0),new Point(-3,0));
            bool levantou = false;
            try//Trocar pelo asset correto
            {
                Point p = l.IntersectionPoint(m);
            }
            catch
            {
                levantou = true;
            }
            Assert.AreEqual(levantou, true);
        }
        [TestMethod]
        public void instersection_point_18()
        {
            Line l = new Line(new Point(-9,6), new Point(-4,1));
            bool levantou = false;
            try//Trocar pelo asset correto
            {
                Point p = l.IntersectionPoint(l);
            }
            catch
            {
                levantou = true;
            }
            Assert.AreEqual(levantou, true);
        }
        [TestMethod]
        public void instersection_point_19()
        {
            Line l = new Line(new Point(2,1), new Point(2,12)),
            m = new Line(new Point(2,12),new Point(2,11.9998));
            bool levantou = false;
            try//Trocar pelo asset correto
            {
                Point p = l.IntersectionPoint(m);
            }
            catch
            {
                levantou = true;
            }
            Assert.AreEqual(levantou, true);
        }
        [TestMethod]
        public void instersection_point_20()
        {
            Line l = new Line(new Point(2, 1), new Point(2, 12)),
            m = new Line(new Point(2, 12),new Point(2, 5));
            bool levantou = false;
            try//Trocar pelo asset correto
            {
                Point p = l.IntersectionPoint(m);
            }
            catch
            {
                levantou = true;
            }
            Assert.AreEqual(levantou, true);
        }
        [TestMethod]
        public void instersection_point_21()
        {
            Line l = new Line(new Point(2, 1), new Point(2, 12))
            , m = new Line(new Point(2.0002, 12), new Point(2.0002, 5));
            Point p = l.IntersectionPoint(m);
            Assert.AreEqual(object.ReferenceEquals(p, null), true);
        }
        [TestMethod]
        public void instersection_point_22()
        {
            Line l = new Line(new Point(2,0), new Point(6,0))
            , m = new Line(new Point(1.9998, 0), new Point(6.0002, 0));
            Point p = l.IntersectionPoint(m);
            Assert.AreEqual(object.ReferenceEquals(p, null), true);
        }
        [TestMethod]
        public void instersection_point_23()
        {
            Line l = new Line(new Point(4, 0), new Point(6, 0))
            , m = new Line(new Point(3, 0), new Point(8, 0));
            Point p = l.IntersectionPoint(m);
            Assert.AreEqual(object.ReferenceEquals(p, null), true);
        }
        [TestMethod]
        public void instersection_point_24()
        {
            Line l = new Line(new Point(4, 1), new Point(4, 12))
            , m = new Line(new Point(7, 0), new Point(7, 10));
            Point p = l.IntersectionPoint(m);
            Assert.AreEqual(object.ReferenceEquals(p, null), true);
        }
        [TestMethod]
        public void instersection_point_25()
         {
            Line m = new Line(new Point(-2, 0), new Point(2, 0))
            , l = new Line(new Point(-5, 0), new Point(-2, 1));
            Point p = l.IntersectionPoint(m)
            , esperado = new Point(-1.9,0.8); 
            Assert.AreEqual(p,esperado);
        }
        [TestMethod]
        public void instersection_point_26()
        {
            Line m = new Line(new Point(2, 0), new Point(4, 0))
            , l = new Line(new Point(1, 0), new Point(3, 1));
            Point p = l.IntersectionPoint(m)
            , esperado = new Point(3,1);
            Assert.AreEqual(p,esperado);
        }
        [TestMethod]
        public void instersection_point_27()
        {
            Line m = new Line(new Point(2, 0), new Point(4, 0))
            , l = new Line(new Point(1, 0), new Point(3.5, 0));
            Point p = l.IntersectionPoint(m)
            , esperado = new Point(3,1);
            Assert.AreEqual(p,esperado);
        }
        #endregion
        #region Belongs
        [TestMethod]
        public void _23()
        {
            Line l = new Line(new Point(-1, 0), new Point(3, 0));
            Point p = new Point(1,2);
            Assert.AreEqual(l.Belongs(p), true);
        }
        
        public void _24()
        {
            Line l = new Line(new Point(-1, 0), new Point(3, 0));
            Point p = new Point(1,3);
            Assert.AreEqual(l.Belongs(p), false);
        }
        
        public void _25()
        {
            Line l = new Line(new Point(3, 0), new Point(13, 0));
            Point p = new Point(11,4);
            Assert.AreEqual(l.Belongs(p), true);
        }
        
        public void _26()
        {
            Line l = new Line(new Point(3, 0), new Point(13, 0));
            Point p = new Point(11,0);
            Assert.AreEqual(l.Belongs(p), false);
        }
        
        public void _27()
        {
            Line l = new Line(new Point(1, 0), new Point(1, 1));
            Point p = new Point(11,0);
            Assert.AreEqual(l.Belongs(p), false);
        }
        
        public void _28()
        {
            Line l = new Line(new Point(7, 0), new Point(7, 1));
            Point p = new Point(7,0);
            Assert.AreEqual(l.Belongs(p), true);
        }
        public void belongs_7()
        {
            Line l = new Line(new Point(-3, 0), new Point(-9, 0));
            Point p = new Point(-9, 0);
            Assert.AreEqual(l.Belongs(p), true);
        }
        public void belongs_8()
        {
            Line l = new Line(new Point(-3, 0), new Point(-9, 0));
            Point p = new Point(-6, 0);
            Assert.AreEqual(l.Belongs(p), false);
        }
        public void belongs_9()
        {
            Line l = new Line(new Point(4, 3), new Point(5, 2*Math.Sqrt(2)));
            Point p = new Point(6,Math.Sqrt(6));
            Assert.AreEqual(l.Belongs(p), true);
        }
        public void belongs_10()
        {
            Line l = new Line(new Point(4, 3), new Point(5, 2*Math.Sqrt(2)));
            Point p = new Point(23, 0.0005);
            Assert.AreEqual(l.Belongs(p), false);
        }
        public void belongs_11()
        {
            Line l = new Line(new Point(2, 5), new Point(2, 2));
            Point p = new Point(2, 0);
            Assert.AreEqual(l.Belongs(p), true);
        }
        public void belongs_12()
        {
            Line l = new Line(new Point(2, 5), new Point(2, 2));
            Point p = new Point(2.0002, 0);
            Assert.AreEqual(l.Belongs(p), false);
        }
        
        #endregion
        #region IsInTheSameSide
        [TestMethod]
        public void _29()
        {
            Line l = new Line(new Point(1, 0), new Point(3, 0));
            Point p = new Point(2, 1)
            , r = new Point(5, 5);
            bool passou = false;
            try
            {
                l.IsInTheSameSide(p, r);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }
        
        [TestMethod]
        public void _30()
        {
            Line l = new Line(new Point(1, 0), new Point(1, 1));
            Point p = new Point(2, 1)
            , r = new Point(1, 78);
            bool passou = false;
            try
            {
                l.IsInTheSameSide(p, r);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }
        
        [TestMethod]
        public void _31()
        {
            Line l = new Line(new Point(5, 0), new Point(5, 1));
            Point p = new Point(14, 35)
            , r = new Point(5, 12.6);
            bool passou = false;
            try
            {
                l.IsInTheSameSide(p, r);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }
        
        [TestMethod]
        public void _32()
        {
            Line l = new Line(new Point(2, 0), new Point(2, 1));
            Point p = new Point(1,2)
            , r = new Point(-3,7);
            Assert.AreEqual(l.IsInTheSameSide(p, r), true);
        }
        
        [TestMethod]
        public void _33()
        {
            Line l = new Line(new Point(2, 0), new Point(2, 1));
            Point p = new Point(5,2)
            , r = new Point(12,7);
            Assert.AreEqual(l.IsInTheSameSide(p, r), true);
        }
        
        [TestMethod]
        public void _34()
        {
            Line l = new Line(new Point(5, 0), new Point(5, 1));
            Point p = new Point(12,2)
            , r = new Point(-3,7);
            Assert.AreEqual(l.IsInTheSameSide(p, r), false);
        }
        
        [TestMethod]
        public void _35()
        {
            Line l = new Line(new Point(15, 0), new Point(15, 1));
            Point p = new Point(-72,2)
            , r = new Point(27,7);
            Assert.AreEqual(l.IsInTheSameSide(p, r), false);
        }        
        [TestMethod]
        public void _36()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Point p = new Point(-2, 3)
            , r = new Point(0.5, 9);
            Assert.AreEqual(l.IsInTheSameSide(p, r), true);
        }        
        [TestMethod]
        public void _37()
        {
            Line l = new Line(new Point(-7, 0), new Point(7, 0));
            Point p = new Point(-2, 3)
            , r = new Point(0.5, 2);
            Assert.AreEqual(true,l.IsInTheSameSide(p, r));
        }        
        [TestMethod]
        public void _39()
        {
            Line l = new Line(new Point(-7, 0), new Point(7, 0));
            Point p = new Point(-27,3)
            , r = new Point(5,1);
            Assert.AreEqual(l.IsInTheSameSide(p, r), false);
        }        
        [TestMethod]
        public void Is_In_The_Same_Side_11()
        {
            Line l = new Line(new Point(2, 3), new Point(2, 8));
            Point p = new Point(-3, 5)
            , r = new Point(0,12);
            Assert.AreEqual(l.IsInTheSameSide(p, r), true);
        }        
        [TestMethod]
        public void Is_In_The_Same_Side_12()
        {
            Line l = new Line(new Point(4, 0), new Point(8, 0));
            Point p = new Point(3, 5)
            , r = new Point(6, 1);
            Assert.AreEqual(l.IsInTheSameSide(p, r), false);
        }        
        [TestMethod]
        public void Is_In_The_Same_Side_13()
        {
            Line l = new Line(new Point(4, 0), new Point(8, 0));
            Point p = new Point(7, 1)
            , r = new Point(5,1);
            Assert.AreEqual(l.IsInTheSameSide(p, r), true);
        }
        [TestMethod]
        public void Is_In_The_Same_Side_14()
        {
            Line l = new Line(new Point(4, 0), new Point(8, 0));
            Point p = new Point(6, 2)
            , r = new Point(5, 1);
            bool passou = false;
            try
            {
                l.IsInTheSameSide(p, r);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }

        #endregion
        #region Cut
        [TestMethod]
        public void _40()
        {
            Line l = new Line(new Point(0, 0), new Point(1, 0));
            Line cut =  new Line(new Point(1, 0), new Point(1,5))
            , output;
            Point reference = new Point(1,5);
            bool passou = false;
            try
            {
                output = l.Cut(cut, reference);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }

        [TestMethod]
        public void _41()
        {
            Line l = new Line(new Point(2, 0), new Point(5, 0));
            Line cut =  new Line(new Point(1, 0), new Point(3,0))
            , output;
            Point reference = new Point(2,1);
            bool passou = false;
            try
            {
                output = l.Cut(cut, reference);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }
        [TestMethod]
        public void _42()//ub
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut =  new Line(new Point(-1, 0), new Point(-1, 1))
            , output;
            Point reference = new Point(5,9);
            output = l.Cut(cut, reference);
            Assert.AreEqual(output, l);
        }

        [TestMethod]
        public void _43()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut =  new Line(new Point(1, 0), new Point(5, 0))
            , output;
            Point reference = new Point(5,0.5);
            output = l.Cut(cut, reference);
            Assert.AreEqual(output, l);
        }

        [TestMethod]
        public void _44()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0))
            ; Line cut = new Line(new Point(3, 0), new Point(5, 0));
            Point reference = new Point(5,0.5);
            Assert.AreEqual(l.Cut(cut, reference),l);
        }

        [TestMethod]
        public void _45()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut = new Line(new Point(3, 0), new Point(5, 0));
            Point reference = new Point(0, 0);
            Assert.AreEqual(l.Cut(cut, reference), l);
        }
        [TestMethod]
        public void _46()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut =  new Line(new Point(-0.5, 0), new Point(0.5,0))
            , output;
            Point reference = new Point(-0.5,0);
            bool passou = false;
            try
            {
                output = l.Cut(cut, reference);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }

        [TestMethod]
        public void _47()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut =  new Line(new Point(-0.5, 0), new Point(0.5, 0));
            Point reference = new Point(2, 0);
            Assert.AreEqual(l.Cut(cut, reference), l);
        }

        [TestMethod]
        public void _48()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut = new Line(new Point(-0.5, 0), new Point(0.5, 0));
            Point reference = new Point(0,0);
            Assert.IsNull(l.Cut(cut, reference));
        }

        [TestMethod]
        public void _49()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut =  new Line(new Point(0.5, 0), new Point(0.5, 1))
            , output;
            Point reference = new Point(0, 0);
            output = l.Cut(cut, reference);
            Assert.AreEqual(output, new Ray(new Point(0.5,Math.Sqrt(0.75)), l.Alfa));
        }

        [TestMethod]
        public void _50()
        {
            Line l = new Line(new Point(-1, 0), new Point(1, 0));
            Line cut =  new Line(new Point(-0.5, 0), new Point(-0.5, 1))
            , output;
            Point reference = new Point(0, 0);
            output = l.Cut(cut, reference);
            Assert.AreEqual(output, new Ray(new Point(-0.5,Math.Sqrt(0.75)), l.Beta));
        }
        [TestMethod]
        public void Cut_12()
        {
            Line l = new Line(new Point(14, 3), new Point(14, 1));
            Line cut =  new Line(new Point(2, 5), new Point(2, 7))
            , output;
            Point reference = new Point(14,7);
            bool passou = false;
            try
            {
                output = l.Cut(cut, reference);
            }
            catch
            {
                
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }
        [TestMethod]
        public void Cut_13()
        {
            Line l = new Line(new Point(7, 0), new Point(13, 0));
            Line cut =  new Line(new Point(9, 81), new Point(9, 2))
            , output;
            Point reference = new Point(10,3);
            bool passou = false;
            try
            {
                output = l.Cut(cut, reference);
            }
            catch
            {
                passou = true;
            }
            Assert.AreEqual(passou, true);
        }
        #endregion
        #region Zoom
        
        [TestMethod]
        public void _51()
        {
            Line l = new Line(new Point(1, 0), new Point(3, 0))
            , output;
            int z = 6;
            output = l.Zoom(z);
            Assert.AreEqual(output, new Line(new Point(6,0), new Point(18,0)));
        }

        [TestMethod]
        public void _52()
        {
            Line l = new Line(new Point(2, 0), new Point(2, 1))
            , output;
            int z = 5;
            output = l.Zoom(z);
            Assert.AreEqual(output, new Line(new Point(10,0), new Point(10,1)));
        }
        [TestMethod]
        public void Zoom_3()
        {
            Line l = new Line(new Point(2, 5), new Point(2, 2))
            , output;
            int z = 1000;
            output = l.Zoom(z);
            Assert.AreEqual(output, new Line(new Point(2000,5000), new Point(2000,2000)));
        }
        [TestMethod]
        public void Zoom_4()
        {
            Line l = new Line(new Point(-3, 0), new Point(-9, 0))
            , output;
            int z = 100;
            output = l.Zoom(z);
            Assert.AreEqual(output, new Line(new Point(-300, 0), new Point(-900, 0)));
        }
        [TestMethod]
        public void Zoom_5()
        {
            Line l = new Line(new Point(4, 3), new Point(5, 2*Math.Sqrt(2)))
            , output;
            int z = 10;
            output = l.Zoom(z);
            Assert.AreEqual(output, new Line(new Point(40,30), new Point(50,20*Math.Sqrt(2))));
        }

        #endregion
        #region Clone

        [TestMethod]
        public void clone_1()
        {
            Point a = new Point(-3, 0), b = new Point(-9, 0);
            Line l = new Line(a, b);
            Assert.AreEqual(l.Clone() as Line == l, true );
        }
        [TestMethod]
        public void clone_2()
        {
            Point a = new Point(4, 3), b = new Point(5, 2 * Math.Sqrt(2));
            Line l = new Line(a, b);
            Assert.AreEqual(l.Clone() as Line == l, true );
        }
        [TestMethod]
        public void clone_3()
        {
            Point a = new Point(2, 5), b = new Point(2, 2);
            Line l = new Line(a, b);
            Assert.AreEqual(l.Clone() as Line == l, true );
        }
        #endregion
    }
}
