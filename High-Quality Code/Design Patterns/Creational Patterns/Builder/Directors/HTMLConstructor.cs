namespace Builder.Directors
{
    using Builder.Builders;

    /// <summary>
    /// The 'Director' class
    /// Constructs an object using the Builder interface
    /// </summary>
    public class HTMLConstructor : IHTMLConstructor
    {
        public void ConstructHTMLPage(HTMLPageBuilder bilder)
        {
            bilder.BuildDoctype();
            bilder.BuildHead();
            bilder.BuildBody();
        }
    }
}
