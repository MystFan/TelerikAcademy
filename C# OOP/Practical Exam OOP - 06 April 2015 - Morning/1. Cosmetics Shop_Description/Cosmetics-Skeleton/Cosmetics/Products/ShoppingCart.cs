


namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> products;
        public ShoppingCart()
        {
            this.Products = new List<IProduct>();
        }

        public ICollection<IProduct> Products
        {
            get
            {
                return new List<IProduct>(this.products);
            }
            private set
            {
                Validator.CheckIfNull(value, "Shoping cart products collection cannot be null");
                this.products = value;
            }
        }
        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Product try to add is null");
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Product try to remove is null");
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            Validator.CheckIfNull(product, "Product try check is null");
            if (this.products.Contains(product))
            {
                return true;
            }
            return false;
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = this.products.Sum(p => p.Price);
            return totalPrice;
        }
    }
}
