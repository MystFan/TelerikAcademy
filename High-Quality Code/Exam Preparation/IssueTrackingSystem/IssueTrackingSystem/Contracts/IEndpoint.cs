namespace IssueTrackingSystem.Contracts
{
    using System.Collections.Generic;

    public interface IEndpoint
    {
        string Name { get; } 

        IDictionary<string, string> Parameters { get; }
    }
}
