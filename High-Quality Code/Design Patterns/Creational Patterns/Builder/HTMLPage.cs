namespace Builder
{
    using System.Collections.Generic;

    public class HTMLPage
    {
        private readonly string pageType;
        private readonly List<string> tags = new List<string>();

        public HTMLPage(string pageType)
        {
            this.pageType = pageType;
        }

        public void AddTag(string tagToAdd)
        {
            this.tags.Add(tagToAdd);
        }

        public string Content()
        {
            string pageAsString = string.Join("\n", this.tags);
            return pageAsString;
        }
    }
}
