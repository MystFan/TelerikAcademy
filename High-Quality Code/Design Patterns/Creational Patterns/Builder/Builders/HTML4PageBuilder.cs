namespace Builder.Builders
{
    public class HTML4PageBuilder : HTMLPageBuilder
    {
        public HTML4PageBuilder()
        {
            this.Page = new HTMLPage("html:4");
        }

        public override void BuildDoctype()
        {
            this.Page.AddTag("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01//EN\"\"http://www.w3.org/TR/html4/strict.dtd\">");
        }

        public override void BuildHead()
        {
            this.Page.AddTag("<head><title></title></head>");
        }

        public override void BuildBody()
        {
            this.Page.AddTag("<body></body>");
        }
    }
}
