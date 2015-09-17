namespace StrategyPattern
{
    public interface IDocumentCompiler
    {
        IDocument Document { get; set; }
        string BuildDocument(string title, string[] headerRows, string[] bodyRows, string[] footerRows);
    }
}
