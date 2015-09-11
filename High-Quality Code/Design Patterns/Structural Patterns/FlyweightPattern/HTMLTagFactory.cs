namespace FlyweightPattern
{
    using System;
    using System.Collections.Generic;

    public class HTMLTagFactory
    {
        private readonly Dictionary<string, HTMLTag> tags = new Dictionary<string, HTMLTag>();

        public HTMLTag GetHTMLTag(string tagName)
        {
            HTMLTag tag = null;
            if (this.tags.ContainsKey(tagName))
            {
                tag = this.tags[tagName];
            }
            else
            {
                switch (tagName)
                {
                    case "p":
                        tag = new ParagraphTag();
                        break;
                    case "div":
                        tag = new DivTag();
                        break;
                    case "strong":
                        tag = new StrongTag();
                        break;
                }

                this.tags.Add(tagName, tag);
            }

            return tag;
        }
    }
}
