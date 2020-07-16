using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polynomials;

namespace PolynomialsTest
{
    [TestClass]
    public class PolynomialTest
    {
        [TestMethod]
        public void TestEqualities_UnequalPolinoms()
        {
            Polynomial p1 = new Polynomial(new double[] { 1, 2, 5, 4 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 3, 1, 5, 4 }, 3);
            Assert.AreEqual(false, p1 == p2);
        }

        [TestMethod]
        public void TestEqualities_UnequalPolinoms1()
        {
            Polynomial p1 = new Polynomial(new double[] { 1, 2, 5 }, 2);
            Polynomial p2 = new Polynomial(new double[] { 3, 1, 5, 4 }, 3);
            Assert.AreEqual(false, p1 == p2);
        }

        [TestMethod]
        public void TestEqualities_EqualPolinoms()
        {
            Polynomial p1 = new Polynomial(new double[] { 1, 2, 5, 4 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 1, 2, 5, 4 }, 3);
            Assert.AreEqual(true, p1 == p2);
        }

        [TestMethod]
        public void TestInequalities_EqualPolinoms()
        {
            Polynomial p1 = new Polynomial(new double[] { 1.005, 2.254, 5.25, 4.1 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 1.005, 2.254, 5.25, 4.1 }, 3);
            Assert.AreEqual(false, p1 != p2);
        }

        [TestMethod]
        public void TestInequalities_UnequalPolinoms()
        {
            Polynomial p1 = new Polynomial(new double[] { 1.005, 2.254, 5.25, 4.1 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 1.001, 2.255, 5.25, 4.1 }, 3);
            Assert.AreEqual(true, p1 != p2);
        }

        [TestMethod]
        public void TestAdditions()
        {
            Polynomial p1 = new Polynomial(new double[] { 2, -5, 5.25, 4.1 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 1.001, 2.255, 12.25}, 2);
            Assert.AreEqual(new Polynomial(new double[] { 3.001, -2.745, 17.5, 4.1}, 3), p1 + p2);
        }

        [TestMethod]
        public void TestAdditions2()
        {
            Polynomial p1 = new Polynomial(new double[] { 1, 2, 3, 4 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 1, 2, 3, 4 }, 3);
            Assert.AreEqual(new Polynomial(new double[] { 2, 4, 6, 8 }, 3), p1 + p2);
        }

        [TestMethod]
        public void TestDifferences()
        {
            Polynomial p1 = new Polynomial(new double[] { 2, 3, 4, 5 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 1, 2, 3, 4 }, 3);
            Assert.AreEqual(new Polynomial(new double[] { 1, 1, 1, 1 }, 3), p1 - p2);
        }

        [TestMethod]
        public void TestDifferences2()
        {
            Polynomial p1 = new Polynomial(new double[] { 2, 3, 4, 5 }, 3);
            Polynomial p2 = new Polynomial(new double[] { 1, 2, 3 }, 2);
            Assert.AreEqual(new Polynomial(new double[] { 1, 1, 1, 5 }, 3), p1 - p2);
        }

        [TestMethod]
        public void TestMultiplicationByNumber()
        {
            Polynomial p1 = new Polynomial(new double[] { 2, 3, 4, 5 }, 3);
            Assert.AreEqual(new Polynomial(new double[] { 6, 9, 12, 15 }, 3), p1 * 3);
        }

        [TestMethod]
        public void TestDividingByNumber()
        {
            Polynomial p1 = new Polynomial(new double[] { 6, 9, 12, 15 }, 3);
            Assert.AreEqual(new Polynomial(new double[] { 2, 3, 4, 5 }, 3), p1 / 3);
        }


    }
}
