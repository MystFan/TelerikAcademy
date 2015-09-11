namespace FlyweightPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FlyweightPattern
    {
        public static void Main()
        {
            List<string> pageTags = new List<string>()
            {
                "p",
                "p",
                "div",
                "strong",
                "div",
                "p"
            };

            HTMLTagFactory factory = new HTMLTagFactory();
            StringBuilder sb = new StringBuilder();
            sb.Append("a");

            foreach (var tag in pageTags)
            {
                sb.Append(sb.ToString());
                var element = factory.GetHTMLTag(tag);
                Console.WriteLine(element.Display(sb.ToString()));
            }
        }
    }
}
