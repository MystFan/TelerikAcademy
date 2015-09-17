using System.Text;
namespace StrategyPattern
{
    public class RegularDocument : IDocument
    {
        public string CreateHeader(string title, string[] content)
        {
            string result = (new string('#', 10) + title + new string('#', 10)) + "\n";

            result += AppendRows(content);

            return result;
        }

        public string CreateBody(string[] content)
        {
            string result = AppendRows(content);
            return result;
        }

        public string CreateFooter(string[] content)
        {
            string result = AppendRows(content);
            result += "\nFooter:";
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
