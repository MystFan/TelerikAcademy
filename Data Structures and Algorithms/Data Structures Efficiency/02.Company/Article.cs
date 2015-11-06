namespace _02.Company
{
    public class Article : IArticle
    {
        public Article(string barcode, string title, decimal price, string vendor)
        {
            this.Barcode = barcode;
            this.Title = title;
            this.Price = price;
            this.Vendor = vendor;
        }

        public string Title { get; set; }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Barcode.CompareTo(((Article)obj).Barcode);
        }
    }
}
