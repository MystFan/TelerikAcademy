namespace InformationalApplication.Models
{
    using System.Collections.Generic;

    public class Category
    {
        private ICollection<Product> products;

        public Category()
        {
            this.products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }
    }
}