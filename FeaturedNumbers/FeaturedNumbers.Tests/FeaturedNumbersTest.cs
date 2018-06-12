using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FeaturedNumbers.Tests
{
    [TestClass]
    public class FeaturedNumbersTest
    {
        [TestMethod]
        public void TestOddNumber()
        {
            Assert.IsTrue(MathHelper.ifOdd(7));
        }

        [TestMethod]
        public void TestDivisionByThree()
        {
            Assert.IsTrue(MathHelper.ifDivideByThree(99));
        }

        [TestMethod]
        public void TestDifferentDigits()
        {
            Assert.IsTrue(MathHelper.ifDifferentDigits(89721));
        }

        [TestMethod]
        public void TestNextFeaturedNumber()
        {
            Assert.AreEqual(15, MathHelper.GetNextFeaturedNumber(12));
            Assert.AreEqual(105, MathHelper.GetNextFeaturedNumber(99));
        }



    }
}
