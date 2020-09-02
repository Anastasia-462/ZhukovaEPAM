using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;

namespace UniversityTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ReportGeneration.OutcomeOfSession();
            Assert.IsTrue(true);
        }
    }
}
