using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;
using System;
using System.Collections.Generic;
using System.IO;
using Moq;

namespace PermutationsTest
{
    [TestClass]
    public class PermutationDisplayerTests
    {

        [TestMethod]
        public void TestMoqListConcatonator()
        {
            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filename = basePath + "\\Permutations\\Files\\SingleTest.txt";

            var ListConcatonatorMock = new Mock<IListConcatonator>();
            var ListStringMock = new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };
            ListConcatonatorMock.Setup(lc => lc.ConcatList(ListStringMock)).Returns("abc,acb,bac,bca,cab,cba");

            var permutationDisplayer = new PermutationDisplayer(new FileProcessor(), new PermutationCalcer(),
                new SpecialComparer(), ListConcatonatorMock.Object);

            var result = permutationDisplayer.displayPermsFromFile(filename);

            ListConcatonatorMock.Verify(lc => lc.ConcatList(ListStringMock), Times.Once);
            Assert.AreEqual("abc,acb,bac,bca,cab,cba", result[0]);
           
        }

        [TestMethod]
        public void TestGivenFile()
        {
            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filename = basePath + "\\Permutations\\Files\\GivenTest.txt";
            List<String> strPerms = new PermutationDisplayer().displayPermsFromFile(filename);

            Assert.AreEqual(3, strPerms.Count);
            Assert.AreEqual("aht,ath,hat,hta,tah,tha", strPerms[0]);
            Assert.AreEqual("abc,acb,bac,bca,cab,cba", strPerms[1]);
            Assert.AreEqual("6Zu,6uZ,Z6u,Zu6,u6Z,uZ6", strPerms[2]);

        }

        [TestMethod]
        public void TestTestFile()
        {
            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filename = basePath + "\\Permutations\\Files\\Test.txt";
            List<String> strPerms = new PermutationDisplayer().displayPermsFromFile(filename);

            Assert.AreEqual(3, strPerms.Count);
            Assert.AreEqual("123,132,213,231,312,321", strPerms[0]);
            Assert.AreEqual("xyz,xzy,yxz,yzx,zxy,zyx", strPerms[1]);
            Assert.AreEqual("6Si+,6S+i,6iS+,6i+S,6+Si,6+iS,S6i+,S6+i,Si6+,Si+6,S+6i,S+i6,i6S+,i6+S,iS6+,iS+6,i+6S,i+S6,+6Si,+6iS,+S6i,+Si6,+i6S,+iS6", strPerms[2]);

        }

        [TestMethod]
        public void TestEmptyFile()
        {
            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filename = basePath + "\\Permutations\\Files\\Empty.txt";
            List<String> strPerms = new PermutationDisplayer().displayPermsFromFile(filename);
            
            Assert.AreEqual(0, strPerms.Count);
        
        }
    }
}
