namespace Builder.Builders
{
    public abstract class HTMLPageBuilder
    {
        public HTMLPage Page { get; set; }

        public abstract void BuildHead();

        public abstract void BuildBody();

        public abstract void BuildDoctype();
    }
}
