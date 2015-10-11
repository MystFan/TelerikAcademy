namespace IssueTrackingSystemTests
{
    using System;
    using System.Collections.Generic;

    using Moq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using IssueTrackingSystem.Contracts;
    using IssueTrackingSystem;
    using IssueTrackingSystem.Common;
    using Wintellect.PowerCollections;

    [TestClass]
    public class CreateIssueTests
    {
        [TestMethod]
        public void CreateIssueWithoutCurrentLoginUserShuldReturnRightMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string actuall = tracker.CreateIssue("Test issue", "Test description", IssuePriority.High, new[] { "new" });

            Assert.AreEqual("There is no currently logged in user", actuall);
        }

        [TestMethod]
        public void CreateIssueWithValidDataShuldReturnRightMessageWithId()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.CurrentUser).Returns(new User("Jhon Doe", "123456"));
            mockIssueTrackerData.Setup(d => d.NextIssueId).Returns(1);
            mockIssueTrackerData.Setup(d => d.IssuesByUsername).Returns(new MultiDictionary<string, Problem>(true));
            mockIssueTrackerData.Setup(d => d.IssuesTags).Returns(new MultiDictionary<string, Problem>(true));
            mockIssueTrackerData.Setup(d => d.IssuesById).Returns(new OrderedDictionary<int, Problem>());

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string actuall = tracker.CreateIssue("Test issue", "Test description", IssuePriority.High, new[] { "new" });

            Assert.AreEqual("Issue 1 created successfully.", actuall);
        }
    }
}
