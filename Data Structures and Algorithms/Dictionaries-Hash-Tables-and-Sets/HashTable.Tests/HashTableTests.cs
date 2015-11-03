namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using HashLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashTableTests
    {
        private static HashTable<int, string> table;

        [TestInitialize]
        public void Initialize()
        {
            table = new HashTable<int, string>();

            table.Add(2, "Pesho");
            table.Add(3, "Jhon");
            table.Add(67, "Evlogi");
            table.Add(23, "Jhon");
            table.Add(27, "Pesho");
            table.Add(35, "Jhon");
            table.Add(66, "Evlogi");
            table.Add(11, "Jhon");
            table.Add(32, "Pesho");
            table.Add(19, "Jhon");
            table.Add(12, "Evlogi");
            table.Add(13, "Jhon");
            table.Add(14, "Pesho");
            table.Add(30, "Jhon");
            table.Add(44, "Evlogi");
            table.Add(15, "Jhon");
            table.Add(57, "Pesho");
            table.Add(58, "Jhon");
            table.Add(59, "Evlogi");
            table.Add(60, "Jhon");
            table.Add(0, "Jhon");
            table.Add(123, "Pesho");
            table.Add(124, "Jhon");
            table.Add(125, "Evlogi");
            table.Add(126, "Jhon");
            table.Add(127, "Jhon");
            table.Add(128, "Pesho");
            table.Add(129, "Jhon");
            table.Add(130, "Evlogi");
            table.Add(131, "Jhon");
            table.Add(132, "Jhon");
            table.Add(222, "Pesho");
            table.Add(223, "Jhon");
            table.Add(224, "Evlogi");
            table.Add(225, "Jhon");
        }

        [TestMethod]
        public void ValuesShouldAddedCorrectCount()
        {
            Assert.AreEqual(35, table.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddWithDuplicateKeyShouldThrow()
        {
            HashTable<string, decimal> ht = new HashTable<string, decimal>();
            ht.Add("Batman", 99m);
            ht.Add("Batman", 88m);
        }

        [TestMethod]
        public void FindShouldReturnCorrectValue()
        {
            table.Add(818, "Foo");

            var actuall = table.Find(818);

            Assert.AreEqual("Foo", actuall);
            Assert.AreEqual(36, table.Count);
        }

        [TestMethod]
        public void FindWithNotExistingValueShouldReturnDefaultValue()
        {
            var actuall = table.Find(555);

            Assert.AreEqual(default(string), actuall);
        }

        [TestMethod]
        public void RemoveShouldRemoveValue()
        {
            table.Add(980, "980");
            table.Remove(980);

            var actuall = table.Find(980);

            Assert.AreEqual(default(string), actuall);
            Assert.AreEqual(35, table.Count);
        }

        [TestMethod]
        public void KeysPropertyShouldReturnAllKeys()
        {
            var keys = table.Keys;

            Assert.AreEqual(table.Count, keys.Count());
        }

        [TestMethod]
        public void IndexerSeterShouldSetCorrectly()
        {
            table.Add(977, "JhonDoe");
            table[977] = "Pesho";

            var actuall = table.Find(977);

            Assert.AreEqual("Pesho", actuall);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void IndexerSeterWithNotExistingKeyShouldThrow()
        {
            table[977] = "Pesho";
        }

        [TestMethod]
        public void IndexerGeterShouldGetCorrectValue()
        {
            table.Add(977, "JhonDoe");

            var actuall = table[977];

            Assert.AreEqual("JhonDoe", actuall);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void IndexerGetterWithNotExistingKeyShouldThrow()
        {
            var value = table[1977];
        }

        [TestMethod]
        public void ForeachShouldCorrectly()
        {
            HashTable<TestPoint, string> ht = new HashTable<TestPoint, string>();
            ht.Add(new TestPoint(1, 3), "Item " + 1);
            ht.Add(new TestPoint(10, 3), "Item " + 2);
            ht.Add(new TestPoint(5, 13), "Item " + 3);
            ht.Add(new TestPoint(9, 23), "Item " + 4);

            List<string> points = new List<string>();
            foreach (var item in ht)
            {
                points.Add(item.Key.ToString());
            }

            Assert.IsTrue(points.Contains("(1, 3)"));
            Assert.IsTrue(points.Contains("(10, 3)"));
            Assert.IsTrue(points.Contains("(5, 13)"));
            Assert.IsTrue(points.Contains("(9, 23)"));
        }

        [TestMethod]
        public void ClearShouldClearCorrect()
        {
            table.Clear();

            Assert.AreEqual(0, table.Count);
        }
    }
}
