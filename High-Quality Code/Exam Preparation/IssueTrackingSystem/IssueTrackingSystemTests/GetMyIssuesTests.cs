namespace IssueTrackingSystemTests
{
    using System.Collections.Generic;
    using IssueTrackingSystem;
    using IssueTrackingSystem.Common;
    using IssueTrackingSystem.Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Wintellect.PowerCollections;

    [TestClass]
    public class GetMyIssuesTests
    {
        [TestMethod]
        public void GetMyIssuesWithoutCurrentUserShuldReturnRightMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string actuall = tracker.GetMyIssues();

            Assert.AreEqual("There is no currently logged in user", actuall);
        }

        [TestMethod]
        public void GetMyIssuesWithCurrentUserOneIssueShuldReturnRightIssuesString()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.CurrentUser).Returns(new User("Jhon Doe", "123456"));
            mockIssueTrackerData.Setup(d => d.NextIssueId).Returns(1);
            mockIssueTrackerData.Setup(d => d.IssuesByUsername).Returns(
                new MultiDictionary<string, Problem>(true)
                    {
                        { "Jhon Doe", new Problem("Test issue", "Test description", IssuePriority.Low, new List<string> { "new","test" }) }
                    }
                );

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string actuall = tracker.GetMyIssues();

            Assert.AreEqual("Test issue\r\nPriority: *\r\nTest description\r\nTags: new,test", actuall);
        }

        [TestMethod]
        public void GetMyIssuesWithCurrentUserTwoOrderIssuesShuldReturnRightIssuesString()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.CurrentUser).Returns(new User("Jhon Doe", "123456"));
            mockIssueTrackerData.Setup(d => d.NextIssueId).Returns(1);
            mockIssueTrackerData.Setup(d => d.IssuesByUsername).Returns(
                new MultiDictionary<string, Problem>(true)
                    {
                        { "Jhon Doe", new Problem("Test issue", "Test description", IssuePriority.Low, new List<string> { "new","test" }) },
                        { "Jhon Doe", new Problem("New Issue", "Description", IssuePriority.Low, new List<string> { "new","test" }) }
                    }
                );

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string actuall = tracker.GetMyIssues();

            Assert.AreEqual("New Issue\r\nPriority: *\r\nDescription\r\nTags: new,test\r\nTest issue\r\nPriority: *\r\nTest description\r\nTags: new,test", actuall);
        }
    }
}
