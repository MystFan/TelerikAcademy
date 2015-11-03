namespace Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using HashLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashedSetTests
    {
        private static HashedSet<string> hashedSet;

        [TestInitialize]
        public void Initialize()
        {
            hashedSet = new HashedSet<string>();

            hashedSet.Add("Pesho");
            hashedSet.Add("Jhon");
            hashedSet.Add("Evlogi");
            hashedSet.Add("Jhon");
            hashedSet.Add("Pesho");
            hashedSet.Add("Jhon");
            hashedSet.Add("Evlogi");
            hashedSet.Add("Jhon");
            hashedSet.Add("Pesho");
            hashedSet.Add("Jhon");
            hashedSet.Add("Evlogi");
            hashedSet.Add("Jhon");
            hashedSet.Add("Pesho");
        }

        [TestMethod]
        public void ShouldAddUniqueValues()
        {
            Assert.AreEqual(3, hashedSet.Count);
        }

        [TestMethod]
        public void FindExistingValueShouldReturnTrue()
        {
            Assert.IsTrue(hashedSet.Find("Jhon"));
        }

        [TestMethod]
        public void FindNotExistingValueShouldReturnFalse()
        {
            Assert.IsFalse(hashedSet.Find("JhonDoe"));
        }

        [TestMethod]
        public void RemoveExistingValueShouldCorrectly()
        {
            hashedSet.Remove("Pesho");
            Assert.AreEqual(2, hashedSet.Count);
        }

        [TestMethod]
        public void RemoveNotExistingValueShouldCorrectly()
        {
            hashedSet.Remove("Batman");
            Assert.AreEqual(3, hashedSet.Count);
        }

        [TestMethod]
        public void ClearShouldClearCorrect()
        {
            hashedSet.Clear();
            Assert.AreEqual(0, hashedSet.Count);
        }

        [TestMethod]
        public void UnionShouldReturnCollectionWithUniqueValues()
        {
            HashedSet<string> set = new HashedSet<string>();
            set.Add("value 1");
            set.Add("Pesho");
            var resultSet = hashedSet.Union(set);

            Assert.AreEqual(4, resultSet.Count());
        }

        [TestMethod]
        public void IntersectShouldReturnCollectionWithRepeatValues()
        {
            HashedSet<string> set = new HashedSet<string>();
            set.Add("value 1");
            set.Add("Pesho");
            var resultSet = hashedSet.Intersect(set);

            Assert.AreEqual(1, resultSet.Count());
        }
    }
}
