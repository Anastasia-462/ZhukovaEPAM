using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vectors;

namespace VectorsTest
{
    [TestClass]
    public class Vector3Test
    {
        [TestMethod]
        public void TestEqualities_UnequalVectors()
        {
            Vector3 vector1 = new Vector3(1.22, 2.33, 4.52);
            Vector3 vector2 = new Vector3(2.11, 2.33, 4.76);
            Assert.AreEqual(false, vector1 == vector2);
        }

        [TestMethod]
        public void TestEqualities_EqualVectors()
        {
            Vector3 vector1 = new Vector3(1.22, 2.33, 4.52);
            Vector3 vector2 = new Vector3(1.22, 2.33, 4.52);
            Assert.AreEqual(true, vector1 == vector2);
        }

        [TestMethod]
        public void TestInequalities_EqualVectors()
        {
            Vector3 vector1 = new Vector3(1.22, 2.33, 4.52);
            Vector3 vector2 = new Vector3(1.22, 2.33, 4.52);
            Assert.AreEqual(false, vector1 != vector2);
        }

        [TestMethod]
        public void TestInequalities_UnequalVectors()
        {
            Vector3 vector1 = new Vector3(4.258, 21.3589, 4.5282);
            Vector3 vector2 = new Vector3(12.223, 2.1313, 4.006);
            Assert.AreEqual(true, vector1 != vector2);
        }

        [TestMethod]
        public void TestAdditions()
        {
            Vector3 vector1 = new Vector3(1, 3, 5.05);
            Vector3 vector2 = new Vector3(4, 3, 2.95);
            Assert.AreEqual(new Vector3(5, 6, 8), vector1 + vector2);
        }

        [TestMethod]
        public void TestDifferences()
        {
            Vector3 vector1 = new Vector3(7, 3, 5);
            Vector3 vector2 = new Vector3(4, 3, 2);
            Assert.AreEqual(new Vector3(3, 0, 3), vector1 - vector2);
        }

        [TestMethod]
        public void TestMultiplicationByNumber()
        {
            Vector3 vector1 = new Vector3(7, 3, 5.05);
            double number = 2;
            Assert.AreEqual(new Vector3(14, 6, 10.1), vector1 * number);
        }

        [TestMethod]
        public void TestDividingByNumber()
        {
            Vector3 vector1 = new Vector3(35, 40, 20);
            double number = 5;
            Assert.AreEqual(new Vector3(7, 8, 4), vector1 / number);
        }

        [TestMethod]
        public void TestScalarMultiplication()
        {
            Vector3 vector1 = new Vector3(4.258, 21.3589, 4.5282);
            Vector3 vector2 = new Vector3(12.223, 2.1313, 4.006);
            Assert.AreEqual(115.70772677, vector1 * vector2);
        }

        [TestMethod]
        public void TestVectorMultiplication()
        {
            Vector3 vector1 = new Vector3(2, 14, 9);
            Vector3 vector2 = new Vector3(8, 15, 6);
            Assert.AreEqual(new Vector3(-51, 60, -82), Vector3.VectorMultiplication(vector1, vector2));
        }
    }
}
