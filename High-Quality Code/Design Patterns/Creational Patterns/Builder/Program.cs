namespace Builder
{
    using System;
    using Builder.Builders;
    using Builder.Directors;

    public class Program
    {
        public static void Main()
        {
            IHTMLConstructor constructor = new HTMLConstructor();

            HTML5PageBuilder html5Builder = new HTML5PageBuilder();
            constructor.ConstructHTMLPage(html5Builder);
            Console.WriteLine(html5Builder.Page.Content());

            Console.WriteLine(new string('-', 20));

            HTML4PageBuilder html4Builder = new HTML4PageBuilder();
            constructor.ConstructHTMLPage(html4Builder);
            Console.WriteLine(html4Builder.Page.Content());
        }
    }
}
