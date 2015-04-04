

namespace MusicShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MusicShopManager.Interfaces;
    public class MusicShop : IMusicShop
    {
        private string name;
        public MusicShop(string name)
        {
            this.Name = name;
            this.Articles = new List<IArticle>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Music shop name is null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Music shop name is empty string");
                }
                this.name = value;
            }
        }

        public IList<IArticle> Articles { get; private set; }

        public void AddArticle(IArticle article)
        {
            if (article != null)
            {
                if (this.Articles.All(a => a.Make != article.Make || a.Model != article.Model))// TODO: Check 
                {
                    this.Articles.Add(article);
                }
            }
        }

        public void RemoveArticle(IArticle article)
        {
            if (article != null)
            {
                this.Articles.Remove(article);
            }
        }

        public string ListArticles()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("===== {0} =====", this.Name));
            if (this.Articles.Count == 0)
            {
                sb.AppendLine("The shop is empty. Come back soon.");
            }
            else
            {
                var microphones = this.Articles.Where(a => a.GetType().Name == "Microphone").OrderBy(i => i.Make).ThenBy(i => i.Model);
                if (microphones.Count() > 0)
                {
                    sb.AppendLine("----- Microphones -----");
                    foreach (var item in microphones)
                    {
                        sb.Append(item.ToString());
                    }
                }
                var drums = this.Articles.Where(a => a.GetType().Name == "Drums").OrderBy(i => i.Make).ThenBy(i => i.Model);
                if (drums.Count() > 0)
                {
                    sb.AppendLine("----- Drums -----");
                    foreach (var item in drums)
                    {
                        sb.Append(item.ToString());
                    }
                }
                var electricGuitars = this.Articles.Where(a => a.GetType().Name == "ElectricGuitar").OrderBy(i => i.Make).ThenBy(i => i.Model);
                if (electricGuitars.Count() > 0)
                {
                    sb.AppendLine("----- Electric guitars -----");
                    foreach (var item in electricGuitars)
                    {
                        sb.Append(item.ToString());
                    }
                }
                var acousticGuitars = this.Articles.Where(a => a.GetType().Name == "AcousticGuitar").OrderBy(i => i.Make).ThenBy(i => i.Model);
                if (acousticGuitars.Count() > 0)
                {
                    sb.AppendLine("----- Acoustic guitars -----");
                    foreach (var item in acousticGuitars)
                    {
                        sb.Append(item.ToString());
                    }
                }
                var bassGuitars = this.Articles.Where(a => a.GetType().Name == "BassGuitar").OrderBy(i => i.Make).ThenBy(i => i.Model);
                if (bassGuitars.Count() > 0)
                {
                    sb.AppendLine("----- Bass guitars -----");
                    foreach (var item in bassGuitars)
                    {
                        sb.Append(item.ToString());
                    }
                }
            }
            return sb.ToString();
        }
    }
}
