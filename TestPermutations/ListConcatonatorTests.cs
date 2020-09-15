using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;
using System.Collections.Generic;

namespace PermutationsTest
{
    [TestClass]
    public class ListConcatonatorTests
    {

        //Higher values should return true
        [TestMethod]
        public void TestValidList()
        {
            ListConcatonator myConcatonator = new ListConcatonator();
            List<string> list = new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };
            string actual = myConcatonator.ConcatList(list);
            Assert.AreEqual("abc,acb,bac,bca,cab,cba",actual);
        }

        [TestMethod]
        public void TestNullList()
        {
            ListConcatonator myConcatonator = new ListConcatonator();
            List<string> list = null;
            string actual = myConcatonator.ConcatList(list);
            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void TestEmptyList()
        {
            ListConcatonator myConcatonator = new ListConcatonator();
            List<string> list = new List<string>() { };
            string actual = myConcatonator.ConcatList(list);
            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void TestEmptyFirstValueList()
        {
            ListConcatonator myConcatonator = new ListConcatonator();
            List<string> list = new List<string>() { "" };
            string actual = myConcatonator.ConcatList(list);
            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void TestNullFirstValueList()
        {
            ListConcatonator myConcatonator = new ListConcatonator();
            List<string> list = new List<string>() { null };
            string actual = myConcatonator.ConcatList(list);
            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void TestValidSecondList()
        {
            ListConcatonator myConcatonator = new ListConcatonator();
            List<string> list = new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };
            string actual = myConcatonator.ConcatList(list);
            Assert.AreEqual("abc,acb,bac,bca,cab,cba", actual);
            list = new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };
            actual = myConcatonator.ConcatList(list);
            Assert.AreEqual("abc,acb,bac,bca,cab,cba", actual);
        }


    }
}
