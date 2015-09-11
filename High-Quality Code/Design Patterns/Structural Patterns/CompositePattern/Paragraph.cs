namespace CompositePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Paragraph : PageComponent
    {
        private Dictionary<string, string> attributes;

        public Paragraph(string name, string content)
            : base(name)
        {
            this.attributes = new Dictionary<string, string>();
            this.Content = content;
        }

        public override void AddAttribute(string key, string value)
        {
            this.attributes.Add(key, value);
        }

        public override void RemoveAttribute(string key)
        {
            this.attributes.Remove(key);
        }

        public override void Add(PageComponent page)
        {
            throw new ArgumentException("Cannot add elements");
        }

        public override void Remove(PageComponent page)
        {
            throw new ArgumentException("Cannot remove elements");
        }

        public override string Display(int depth)
        {
            StringBuilder paragraph = new StringBuilder();
            var depthAsString = new string(' ', depth);
            paragraph.Append(depthAsString + "[" + this.Name);
            foreach (var attr in this.attributes)
            {
                paragraph.Append(" " + attr.Key + "=\"" + attr.Value + "\" ");
            }

            paragraph.AppendLine("]");
            paragraph.AppendLine(depthAsString + depthAsString + this.Content);
            paragraph.Append(depthAsString + "[" + this.Name + "]");

            return paragraph.ToString();
        }
    }
}
