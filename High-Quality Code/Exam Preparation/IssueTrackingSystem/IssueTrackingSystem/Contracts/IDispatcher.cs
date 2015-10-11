namespace IssueTrackingSystem.Contracts
{
    public interface IDispatcher
    {
        IIssueTracker Tracker { get; set; }

        string DispatchAction(IEndpoint endpoint);
    }
}
