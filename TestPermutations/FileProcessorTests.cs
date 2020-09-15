using System;
using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace PermutationsTest
{
    [TestClass]
    public class FileProcessorTests
    {

        public static List<string> GetStringsFromMockFileProcessor(string fileData)
        {
            var mockFileSystem = new MockFileSystem();

            var mockInputFile = new MockFileData(fileData);

            mockFileSystem.AddFile(@"C:\temp\in.txt", mockInputFile);

            var fp = new FileProcessor(mockFileSystem);
            List<String> lstStr = fp.GetStringsFromFile(@"C:\temp\in.txt");

            return lstStr;
        }

        [TestMethod]
        public void TestValidFile()
        {
            List<String> lstStr = GetStringsFromMockFileProcessor("line1\nline2\nline3");

            Assert.AreEqual(3, lstStr.Count);
            Assert.AreEqual("line1", lstStr[0]);
            Assert.AreEqual("line2", lstStr[1]);
            Assert.AreEqual("line3", lstStr[2]);
        }


        [TestMethod]
        public void TestValidFileWithEmptyLines()
        {
            List<String> lstStr = GetStringsFromMockFileProcessor("line1\nline2\nline3");

            Assert.AreEqual(3, lstStr.Count); //not 5
            Assert.AreEqual("line1", lstStr[0]);
            Assert.AreEqual("line2", lstStr[1]);
            Assert.AreEqual("line3", lstStr[2]);

        }


        [TestMethod]
        public void TestInvalidFile()
        {
            var mockFileSystem = new MockFileSystem();

            var mockInputFile = new MockFileData("line1\nline2\nline3\\");

            //dont add file
            //mockFileSystem.AddFile(@"C:\temp\in.txt", mockInputFile);

            var sut = new FileProcessor(mockFileSystem);
            List<String> lstStr = sut.GetStringsFromFile(@"C:\temp\in.txt");

            Assert.AreEqual(0, lstStr.Count); //not 5
 
        }

    }
}
