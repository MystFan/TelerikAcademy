namespace IssueTrackingSystemTests
{
    using System;
    using System.Collections.Generic;

    using IssueTrackingSystem;
    using IssueTrackingSystem.Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Wintellect.PowerCollections;
    using IssueTrackingSystem.Common;

    [TestClass]
    public class SearchForIssuesTests
    {

        [TestMethod]
        public void SearchForIssuesWithNullArrayTagsShuldReturnRightMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string result = tracker.SearchForIssues(null);

            Assert.AreEqual("There are no tags provided", result);
        }

        [TestMethod]
        public void SearchForIssuesWithContainsTagsShuldReturnRightIssuesAsString()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.IssuesTags).Returns(
                new MultiDictionary<string, Problem>(true)
                    {
                        { "test", new Problem("Test issue", "Test description", IssuePriority.Low, new List<string> { "new","test" }) },
                        { "new", new Problem("New Issue", "Description", IssuePriority.Low, new List<string> { "new","test" }) }
                    }
                );

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string result = tracker.SearchForIssues(new[] { "new", "test" });

            Assert.AreEqual("New Issue\r\nPriority: *\r\nDescription\r\nTags: new,test\r\nTest issue\r\nPriority: *\r\nTest description\r\nTags: new,test", result);
        }

        [TestMethod]
        public void SearchForIssuesWithNotContainTagsShuldReturnRightMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.IssuesTags).Returns(
                new MultiDictionary<string, Problem>(true)
                    {
                        { "diff", new Problem("Test issue", "Test description", IssuePriority.Low, new List<string> { "diff" }) },
                        { "foo", new Problem("New Issue", "Description", IssuePriority.Low, new List<string> { "foo" }) }
                    }
                );

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string result = tracker.SearchForIssues(new[] { "new", "test" });

            Assert.AreEqual("There are no issues matching the tags provided", result);
        }
    }
}
