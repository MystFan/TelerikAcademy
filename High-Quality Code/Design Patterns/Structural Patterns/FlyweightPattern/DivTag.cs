namespace FlyweightPattern
{
    public class DivTag : HTMLTag
    {
        public DivTag()
        {
            this.Name = "div";
            this.Attributies["display"] = "block";
        }

        public override string Display(string content)
        {
            this.Content = content;
            return this.ToString();
        }
    }
}
