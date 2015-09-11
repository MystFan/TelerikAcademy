namespace FlyweightPattern
{
    public class StrongTag : HTMLTag
    {
        public StrongTag()
        {
            this.Name = "strong";
        }

        public override string Display(string content)
        {
            this.Content = content;
            return this.ToString();
        }
    }
}
