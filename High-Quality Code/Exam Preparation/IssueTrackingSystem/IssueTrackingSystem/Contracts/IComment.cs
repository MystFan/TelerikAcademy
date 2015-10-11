namespace IssueTrackingSystem.Contracts
{
    public interface IComment
    {
        User Author { get; set; }

        string Text { get; set; }
    }
}
