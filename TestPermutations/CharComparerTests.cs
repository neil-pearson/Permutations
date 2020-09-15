using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace PermutationsTest
{
    [TestClass]
    public class CharComparerTests
    {

        //Higher values should return true
        [TestMethod]
        public void TestDigits()
        {
            CharComparer myCharCompare = new CharComparer();
            int actual = myCharCompare.Compare('2', '1');
            Assert.AreEqual(1, actual);
            actual = myCharCompare.Compare('2', '2');
            Assert.AreEqual(0, actual);
            actual = myCharCompare.Compare('2', '3');
            Assert.AreEqual(-1, actual);
            
            actual = myCharCompare.Compare('2', 'C');
            Assert.AreEqual(-1, actual);
            actual = myCharCompare.Compare('2', 'c');
            Assert.AreEqual(-1, actual);
            actual = myCharCompare.Compare('2', '!');
            Assert.AreEqual(-1, actual);
        }

        //Higher values should return true
        [TestMethod]
        public void TestUpper()
        {
            CharComparer myCharCompare = new CharComparer();
            int actual = myCharCompare.Compare('b', '1');
            Assert.AreEqual(1, actual);

            actual = myCharCompare.Compare('B', 'A');
            Assert.AreEqual(1, actual);
            actual = myCharCompare.Compare('B', 'B');
            Assert.AreEqual(0, actual);
            actual = myCharCompare.Compare('B', 'C');
            Assert.AreEqual(-1, actual);
            
            actual = myCharCompare.Compare('B', 'c');
            Assert.AreEqual(-1, actual);
            actual = myCharCompare.Compare('B', '!');
            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestLower()
        {
            CharComparer myCharCompare = new CharComparer();
            int actual = myCharCompare.Compare('b', '1');
            Assert.AreEqual(1, actual);
            actual = myCharCompare.Compare('b', 'B');
            Assert.AreEqual(1, actual);

            actual = myCharCompare.Compare('b', 'a');
            Assert.AreEqual(1, actual);
            actual = myCharCompare.Compare('b', 'b');
            Assert.AreEqual(0, actual);
            actual = myCharCompare.Compare('b', 'c');
            Assert.AreEqual(-1, actual);
            actual = myCharCompare.Compare('b', '!');
            Assert.AreEqual(-1, actual);
        }


        [TestMethod]
        public void TestOther()
        {
            CharComparer myCharCompare = new CharComparer();
            int actual = myCharCompare.Compare('+', '1');
            Assert.AreEqual(1, actual);
            actual = myCharCompare.Compare('+', 'B');
            Assert.AreEqual(1, actual);
            actual = myCharCompare.Compare('+', 'a');
            Assert.AreEqual(1, actual);
            
            actual = myCharCompare.Compare('+', '!');
            Assert.AreEqual(10, actual);
            actual = myCharCompare.Compare('+', '+');
            Assert.AreEqual(0, actual);
            actual = myCharCompare.Compare('!', '+');
            Assert.AreEqual(-10, actual);
        }
    }
}
