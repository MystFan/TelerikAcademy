namespace LongestSubsequenceTests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _04.LongestSubsequenceEqualNumbers;

    [TestClass]
    public class LongestSubsequenceTests
    {

        [TestMethod]
        public void LongestSubsequenceStartShuldReturnCorrectSequence()
        {
            List<int> numbers = new List<int>()
            {
                1,1,1,1,1,345,5,7,432,4,4,4,4,234
            };

            var result = Startup.FindLongestSubsequenceOfEqualNumbers(numbers);

            Assert.AreEqual("1,1,1,1,1", string.Join(",", result));
        }

        [TestMethod]
        public void LongestSubsequenceEndShuldReturnCorrectSequence()
        {
            List<int> numbers = new List<int>()
            {
                345,5,7,432,4,4,4,4,32,4,234,1,1,1,1,1
            };

            var result = Startup.FindLongestSubsequenceOfEqualNumbers(numbers);

            Assert.AreEqual("1,1,1,1,1", string.Join(",", result));
        }

        [TestMethod]
        public void LongestSubsequenceMiddleShuldReturnCorrectSequence()
        {
            List<int> numbers = new List<int>()
            {
                345,5,7,432,1,1,1,1,1,32,4,234,4,4,4,4
            };

            var result = Startup.FindLongestSubsequenceOfEqualNumbers(numbers);

            Assert.AreEqual("1,1,1,1,1", string.Join(",", result));
        }

        [TestMethod]
        public void LongestSubsequenceOneNumberShuldReturnCorrectSequence()
        {
            List<int> numbers = new List<int>()
            {
                345,5,7,432,1,32,4,234,4
            };

            var result = Startup.FindLongestSubsequenceOfEqualNumbers(numbers);

            Assert.AreEqual("345", string.Join(",", result));
        }
    }
}
