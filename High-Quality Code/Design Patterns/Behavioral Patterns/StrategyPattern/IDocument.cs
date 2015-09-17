namespace StrategyPattern
{
    public interface IDocument
    {
        string CreateHeader(string title, string[] rows);

        string CreateBody(string[] rows);

        string CreateFooter(string[] rows);
    }
}
