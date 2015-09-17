namespace StrategyPattern
{
    using System.Text;

    public class SpecialDocument : IDocument
    {
        private readonly int width;

        public SpecialDocument(int width)
        {
            this.width = width;
        }

        public string CreateHeader(string title, string[] rows)
        {
            string titleResult = (new string('<', 10) + title + new string('>', 10));
            string result = new string('-', titleResult.Length) + "\n";
            result += titleResult + "\n";
            result += new string('-', titleResult.Length) + "\n";
            result += AppendRows(rows);

            return result;
        }

        public string CreateBody(string[] rows)
        {
            string result = new string('-', this.width) + "\n";
            result += AppendRows(rows) + "\n";
            result += new string('-', this.width) + "\n";

            return result;
        }

        public string CreateFooter(string[] rows)
        {
            string result = new string('#', this.width);
            result += AppendRows(rows);
            result += new string('#', this.width) + "\n";

            return result;
        }

        private string AppendRows(string[] rows)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows.Length - 1; i++)
            {
                sb.AppendLine(rows[i]);
            }

            sb.Append(rows[rows.Length - 1]);

            return sb.ToString();
        }
    }
}
