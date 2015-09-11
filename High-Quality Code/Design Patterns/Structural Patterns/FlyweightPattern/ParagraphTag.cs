namespace FlyweightPattern
{
    public class ParagraphTag : HTMLTag
    {
        public ParagraphTag()
        {
            this.Name = "p";
            this.Attributies["display"] = "block";
        }

        public override string Display(string content)
        {
            this.Content = content;
            return this.ToString();
        }
    }
}
