namespace CompositePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Document : PageComponent
    {
        private Dictionary<string, string> attributes;
        private List<PageComponent> elements;

        public Document(string name)
            : base(name)
        {
            this.attributes = new Dictionary<string, string>();
            this.elements = new List<PageComponent>();
        }

        public override void AddAttribute(string key, string value)
        {
            this.attributes.Add(key, value);
        }

        public override void RemoveAttribute(string key)
        {
            this.attributes.Remove(key);
        }

        public override string Display(int depth)
        {
            StringBuilder document = new StringBuilder();
            string depthAsString = new string(' ', depth);

            document.Append(depthAsString + "[# " + this.Name);
            foreach (var attr in this.attributes)
            {
                document.Append(" " + attr.Key + "=\"" + attr.Value + "\" ");
            }

            document.AppendLine("#]");

            foreach (var item in this.elements)
            {
                if (item is Document)
                {
                    document.AppendLine(item.Display(depth));
                }
                else
                {
                    document.AppendLine(item.Display(depth * 4));
                }
            }

            document.AppendLine(depthAsString + "[### " + this.Name + " ###]");

            return document.ToString();
        }

        public override void Add(PageComponent pageComponent)
        {
            if (pageComponent == null)
            {
                throw new ArgumentNullException();
            }

            this.elements.Add(pageComponent);
        }

        public override void Remove(PageComponent pageComponent)
        {
            if (pageComponent == null)
            {
                throw new ArgumentNullException();
            }

            this.elements.Remove(pageComponent);
        }
    }
}
