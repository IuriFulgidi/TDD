using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Confronto_Tests
{
    [TestClass]
    public class TDD_Tests
    {
        [TestMethod]
        public void TestMax()
        {
            int num1=4;
            int num2=10;
            int max_expected = 10;

            int max_calculated = TDD_Library.TDD.Max(num1, num2);
            Assert.AreEqual(max_expected, max_calculated);
        }

        [TestMethod]
        public void TestMax1()
        {
            int num1 = 10;
            int num2 = 4;
            int max_expected = 10;

            int max_calculated = TDD_Library.TDD.Max(num1, num2);
            Assert.AreEqual(max_expected, max_calculated);
        }
    }
}
