using System;
using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace PermutationsTest
{
    [TestClass]
    public class StringUtilsTests
    {

        [TestMethod]
        public void SwapTwoChars()
        {
            char first = 'a';
            char second = 'b';
            StringUtils.Swap(ref first, ref second);

            Assert.AreEqual('b', first);
            Assert.AreEqual('a', second);
        }

        [TestMethod]
        public void SwapTwoCharsTheSame()
        {
            char first = 'a';
            char second = 'a';
            StringUtils.Swap(ref first, ref second);

            Assert.AreEqual('a', first);
            Assert.AreEqual('a', second);
        }

        [TestMethod]
        public void GetStringFromEmptyCharArray()
        {
            char[] chars = new char[] {};
            string returnString = StringUtils.getString(chars);

            Assert.AreEqual("", returnString);
        }

        [TestMethod]
        public void GetStringFrom2CharArray()
        {
            char[] chars = new char[] { 'a', 'b' };
            string returnString = StringUtils.getString(chars);

            Assert.AreEqual("ab", returnString);
        }

        [TestMethod]
        public void GetStringFrom3CharArray()
        {
            char[] chars = new char[] { 'a', 'b', 'c' };
            string returnString = StringUtils.getString(chars);

            Assert.AreEqual("abc", returnString);
        }


    }
}
