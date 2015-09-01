namespace Builder.Builders
{
    public class HTML5PageBuilder : HTMLPageBuilder
    {
        public HTML5PageBuilder()
        {
            this.Page = new HTMLPage("html:5");
        }

        public override void BuildDoctype()
        {
            this.Page.AddTag("<!Doctype html>");
        }

        public override void BuildHead()
        {
            this.Page.AddTag("<head></head>");
        }

        public override void BuildBody()
        {
            this.Page.AddTag("<body></body>");
        }
    }
}
