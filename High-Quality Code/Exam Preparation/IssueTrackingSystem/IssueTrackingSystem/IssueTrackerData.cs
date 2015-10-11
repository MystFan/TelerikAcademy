namespace IssueTrackingSystem
{
    using System.Collections.Generic;
    using IssueTrackingSystem.Contracts;
    using Wintellect.PowerCollections;

    public class IssueTrackerData : IIssueTrackerData
    {
        public IssueTrackerData()
        {
            this.NextIssueId = 1;
            this.Users = new Dictionary<string, User>();
            this.IssuesById = new OrderedDictionary<int, Problem>();
            this.IssuesByUsername = new MultiDictionary<string, Problem>(true);
            this.IssuesTags = new MultiDictionary<string, Problem>(true);
            this.UserComment = new MultiDictionary<User, Comment>(true);
        }

        public int NextIssueId { get; set; }

        public User CurrentUser { get; set; }

        public IDictionary<string, User> Users { get; set; }

        public OrderedDictionary<int, Problem> IssuesById { get; set; } 

        public MultiDictionary<string, Problem> IssuesByUsername { get; set; }

        public MultiDictionary<string, Problem> IssuesTags { get; set; }

        public MultiDictionary<User, Comment> UserComment { get; set; }
    }
}
