namespace IssueTrackingSystemTests
{
    using System;
    using System.Collections.Generic;

    using Moq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using IssueTrackingSystem.Contracts;
    using IssueTrackingSystem;

    [TestClass]
    public class RegisterUserTests
    {
        [TestMethod]
        public void RegisterUserWithValidDataShouldReturnSusscessMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.Users).Returns(
                new Dictionary<string, User>()
                {
                    { "Jhon" , new User("Jnon", "123456")},
                    { "Doncho" , new User("Doncho", "123456")},
                    { "Pesho" , new User("Kenov", "123456")},
                });

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string result = tracker.RegisterUser("Stamat", "654321", "654321");

            Assert.AreEqual("User Stamat registered successfully", result);
        }


        [TestMethod]
        public void RegisterUserWithExistingCurrentUserShouldReturnRightMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.CurrentUser).Returns(new User("Jnon", "123456"));

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string result = tracker.RegisterUser("Stamat", "654321", "654321");

            Assert.AreEqual("There is already a logged in user", result);
        }

        [TestMethod]
        public void RegisterUserWithNotMachUserPasswordAndConfirmPasswordShouldReturnRightMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string result = tracker.RegisterUser("Stamat", "654321", "111111");

            Assert.AreEqual("The provided passwords do not match", result);
        }

        [TestMethod]
        public void RegisterUserWithExistingUsernameShouldReturnRightMessage()
        {
            var mockIssueTrackerData = new Mock<IIssueTrackerData>();
            mockIssueTrackerData.Setup(d => d.Users).Returns(
                new Dictionary<string, User>()
                {
                    { "Jhon" , new User("Jnon", "123456")},
                    { "Doncho" , new User("Doncho", "123456")},
                    { "Pesho" , new User("Kenov", "123456")},
                });

            IssueTracker tracker = new IssueTracker(mockIssueTrackerData.Object);
            string result = tracker.RegisterUser("Doncho", "654321", "654321");

            Assert.AreEqual("A user with username Doncho already exists", result);
        }
    }
}
