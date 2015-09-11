namespace CompositePattern
{
    public abstract class PageComponent
    {
        protected PageComponent(string name)
        {
            this.Name = name;
            this.Content = string.Empty;
        }

        protected string Name { get; private set; }

        protected string Content { get; set; }

        public abstract void AddAttribute(string key, string value);

        public abstract void RemoveAttribute(string key);

        public abstract void Add(PageComponent page);

        public abstract void Remove(PageComponent page);

        public abstract string Display(int depth);
    }
}
