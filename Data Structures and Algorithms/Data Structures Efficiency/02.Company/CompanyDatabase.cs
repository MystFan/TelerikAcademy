namespace _02.Company
{
    ﻿using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class CompanyDatabase
    {
        private readonly OrderedMultiDictionary<string, IArticle> ArticlesByBarcode;
        private readonly OrderedMultiDictionary<decimal, IArticle> ArticlesByPrice;

        public CompanyDatabase()
        {
            this.ArticlesByBarcode = new OrderedMultiDictionary<string, IArticle>(true);
            this.ArticlesByPrice = new OrderedMultiDictionary<decimal, IArticle>(true);
        }

        public void AddArticle(IArticle article)
        {
            if (article == null)
            {
                throw new ArgumentNullException("Parameter cannot be null.");
            }

            this.ArticlesByBarcode.Add(article.Barcode, article);
            this.ArticlesByPrice.Add(article.Price, article);
        }

        public ICollection<IArticle> GetByPriceRange(decimal from, decimal to)
        {
            ICollection<IArticle> result = this.ArticlesByPrice.Range(from, true, to, true).Values;
            return result;
        }
    }
}
