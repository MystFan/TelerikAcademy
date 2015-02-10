using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.AppearanceCount;
namespace Tests
{
    [TestClass]
    public class MethodsTests
    {
        [TestMethod]
        public void TestAppearancesOnElementInGivenCollection()
        {
            string[] strings = new string[]
            {
                "Pesho",
                "Pesho Peshev",
                "Some text",
                "Regular text",
                "Pesho",
                "Pesho",
                "Pesho",
                "Nikolai Kostov",
                "Doncho Minkov",
                "Ivaylo Kenov",
                "Some long long long text"
            };

            int count = AppearanceCount.Appearances(strings, "Pesho");
            int expect = 4;
            Assert.AreEqual(expect, count);

            double[] doubles = new double[] { 3.4, 3.4, 3.4, 2.9, 1.7, 2.67 };
            count = AppearanceCount.Appearances(doubles, 3.4);
            expect = 3;
            Assert.AreEqual(expect, count);
        }
    }
}
