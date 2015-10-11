namespace IssueTrackingSystem.Contracts
{
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public interface IIssueTrackerData
    {
        int NextIssueId { get; set; }

        User CurrentUser { get; set; }

        IDictionary<string, User> Users { get; }

        OrderedDictionary<int, Problem> IssuesById { get; }

        MultiDictionary<string, Problem> IssuesByUsername { get; }

        MultiDictionary<string, Problem> IssuesTags { get; }

        MultiDictionary<User, Comment> UserComment { get; }
    }
}
