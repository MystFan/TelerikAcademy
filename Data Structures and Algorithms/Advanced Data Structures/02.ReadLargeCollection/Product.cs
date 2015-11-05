namespace _02.ReadLargeCollection
{
    using System;

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            if(this.Name.CompareTo(other.Name) < 0)
            {
                return -1;
            }

            if(this.Name.CompareTo(other.Name) > 0)
            {
                return 1;
            }

            return this.Price.CompareTo(other.Price);
        }
    }
}
