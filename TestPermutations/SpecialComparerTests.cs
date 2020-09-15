using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace PermutationsTest
{
    [TestClass]
    public class SpecialComparerTests
    {

        //Higher values should return true
        [TestMethod]
        public void TestStringsDigit()
        {
            SpecialComparer myComparer = new SpecialComparer();
            int actual = myComparer.Compare("2111", "1111");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("2111", "2111");
            Assert.AreEqual(0, actual);
            actual = myComparer.Compare("2111", "3111");
            Assert.AreEqual(-1, actual);
            actual = myComparer.Compare("2111", "2A11");
            Assert.AreEqual(-1, actual);
            actual = myComparer.Compare("2111", "21a1");
            Assert.AreEqual(-1, actual);
            actual = myComparer.Compare("2111", "211!");
            Assert.AreEqual(-1, actual);
        }

        //Higher values should return true
        [TestMethod]
        public void TestStringsUpper()
        {
            SpecialComparer myComparer = new SpecialComparer();
            int actual = myComparer.Compare("2B11", "2111");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("2B11", "2A11");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("2B11", "2B11");
            Assert.AreEqual(0, actual);
            actual = myComparer.Compare("2B11", "2C11");
            Assert.AreEqual(-1, actual);
            actual = myComparer.Compare("2B11", "2Bb1");
            Assert.AreEqual(-1, actual);
            actual = myComparer.Compare("2B11", "2B1!");
            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestStringsLower()
        {
            SpecialComparer myComparer = new SpecialComparer();
            int actual = myComparer.Compare("2b11", "2111");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("2b11", "2B11");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("2b11", "2a11");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("2b11", "2b11");
            Assert.AreEqual(0, actual);
            actual = myComparer.Compare("2b11", "2cb1");
            Assert.AreEqual(-1, actual);
            actual = myComparer.Compare("2b11", "2b1!");
            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestStringsOther()
        {
            SpecialComparer myComparer = new SpecialComparer();
            int actual = myComparer.Compare("221+", "2211");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("221+", "221B");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("221+", "221b");
            Assert.AreEqual(1, actual);
            actual = myComparer.Compare("221+", "221!");
            Assert.AreEqual(10, actual);
            actual = myComparer.Compare("221+", "221+");
            Assert.AreEqual(0, actual);
            actual = myComparer.Compare("221!", "221+");
            Assert.AreEqual(-10, actual);
        }

    }
}
