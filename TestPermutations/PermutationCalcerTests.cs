using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;
using System.Collections.Generic;

namespace PermutationsTest
{
    [TestClass]
    public class PermutationCalcerTests
    {
        [TestMethod]
        public void CalcPerms0String()
        {
            PermutationCalcer permCalcer = new PermutationCalcer();
            permCalcer.calcPermutations("");

            List<string> perms = permCalcer.permutations;
            Assert.AreEqual(0, perms.Count);
        }
  
        [TestMethod]
        public void CalcPerms1String()
        {
            PermutationCalcer permCalcer = new PermutationCalcer();
            permCalcer.calcPermutations("a");

            List<string> perms = permCalcer.permutations;
            Assert.AreEqual(1, perms.Count);
            Assert.AreEqual("a", perms[0]);
        }

        [TestMethod]
        public void CalcPerms2String()
        {
            PermutationCalcer permCalcer = new PermutationCalcer();
            permCalcer.calcPermutations("ab");

            List<string> perms = permCalcer.permutations;
            Assert.AreEqual(2, perms.Count);
            Assert.AreEqual("ab", perms[0]);
            Assert.AreEqual("ba", perms[1]);
        }

        [TestMethod]
        public void CalcPerms3String()
        {
            PermutationCalcer permCalcer = new PermutationCalcer();
            permCalcer.calcPermutations("abc");

            List<string> perms = permCalcer.permutations;
            Assert.AreEqual(6, perms.Count);
            Assert.AreEqual("abc", perms[0]);
            Assert.AreEqual("acb", perms[1]);
            Assert.AreEqual("bac", perms[2]);
            Assert.AreEqual("bca", perms[3]);
            Assert.AreEqual("cba", perms[4]);
            Assert.AreEqual("cab", perms[5]);
        }
    }
}
