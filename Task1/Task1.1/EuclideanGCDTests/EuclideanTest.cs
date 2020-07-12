using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclideanGCD;

namespace EuclideanGCDTests
{
    [TestClass]
    public class EuclideanTest
    {
        [TestMethod]
        public void GCD_2intNumbers()
        {
            Euclidean euclidean = new Euclidean();
            TimeSpan watch;
            int res = euclidean.GCD(15, 26, out watch);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void GCD_2negativeIntNumbers()
        {
            Euclidean euclidean = new Euclidean();
            TimeSpan watch;
            int res = euclidean.GCD(-5, -10, out watch);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void GCD_0And1Numbers()
        {
            Euclidean euclidean = new Euclidean();
            TimeSpan watch;
            int res = euclidean.GCD(0, 1, out watch);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void GCD_3intNumbers()
        {
            Euclidean euclidean = new Euclidean();
            int res = euclidean.GCD(3, 12, 23);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void GCD_4intNumbers()
        {
            Euclidean euclidean = new Euclidean();
            int res = euclidean.GCD(2, 4, 8, 16);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void GCD_5intNumbers()
        {
            Euclidean euclidean = new Euclidean();
            int res = euclidean.GCD(11, 22, 33, 44, 55);
            Assert.AreEqual(11, res);
        }

        [TestMethod]
        public void BinGCD_2intNumbers()
        {
            Euclidean euclidean = new Euclidean();
            TimeSpan watch;
            int res = euclidean.BinGCD(3, 9, out watch);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void BinGCD_2negativeIntNumbers()
        {
            Euclidean euclidean = new Euclidean();
            TimeSpan watch;
            int res = euclidean.BinGCD(-3, -2, out watch);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void BinGCD_0And0Numbers()
        {
            Euclidean euclidean = new Euclidean();
            TimeSpan watch;
            int res = euclidean.BinGCD(0, 0, out watch);
            Assert.AreEqual(0, res);
        }
    }
}
