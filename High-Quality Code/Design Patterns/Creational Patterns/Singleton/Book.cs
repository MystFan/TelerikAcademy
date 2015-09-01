namespace Creational_Patterns
{
    public class Book: IReadable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return "title: '" + this.Title + "' author: " + this.Author;
        }
    }
}
