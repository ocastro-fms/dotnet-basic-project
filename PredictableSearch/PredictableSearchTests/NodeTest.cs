namespace PredictableSearchTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PredictableSearch;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void CoutingNodesForAnEmptyNode_00()
        {
            var x = new Node();
            Assert.AreEqual(1, x.Count());
        }

        [TestMethod]
        public void InsertingASimpleWord_01()
        {
            var x = new Node();
            x.Insert("cat");
            Assert.AreEqual(4, x.Count());
        }

        [TestMethod]
        public void InsertingAFamilyOfWords_02()
        {
            var x = new Node();
            x.Insert("cat");
            x.Insert("coat");
            x.Insert("cable");
            Assert.AreEqual(10, x.Count());
        }

        [TestMethod]
        public void SearchAnExistingWord_03()
        {
            var x = new Node();
            x.Insert("cat");
            x.Insert("coat");
            x.Insert("cable");
            var res = x.Search("cat");
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void SearchANonExistingWord_04()
        {
            var x = new Node();
            x.Insert("cat");
            x.Insert("coat");
            x.Insert("cable");
            var res = x.Search("child");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void SearchANonExistingWord_05()
        {
            var x = new Node();
            x.Insert("cat");
            x.Insert("coat");
            x.Insert("cable");
            IEnumerable<string> res = x.Suggest("ca");
            Assert.AreEqual("cat", res.ToList()[0]);
            Assert.AreEqual("cable", res.ToList()[1]);
        }
    }
}
