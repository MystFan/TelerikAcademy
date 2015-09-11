namespace FlyweightPattern
{
    using System.Collections.Generic;

    public abstract class HTMLTag
    {
        protected HTMLTag()
        {
            this.Attributies = new Dictionary<string, string>();
            this.Attributies["display"] = "inline";
            this.Attributies["position"] = "relative";
        }

        public string Name { get; set; }

        public string Content { get; set; }

        public Dictionary<string, string> Attributies { get; set; }

        public abstract string Display(string content);

        public override string ToString()
        {
            return "<" + this.Name + " style=\"display:" + this.Attributies["display"] + "\">" + this.Content + "</" + this.Name + ">";
        }
    }
}
