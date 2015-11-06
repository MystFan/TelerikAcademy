namespace _02.Company
{
    using System;

    public interface IArticle : IComparable
    {
        string Title { get; set; }

        string Barcode { get; set; }

        string Vendor { get; set; }

        decimal Price { get; set; }
    }
}
