
namespace MusicShop.Models
{
    using System;
    using MusicShopManager.Interfaces;
    using MusicShopManager.Models;
    using System.Text;
    public class AcousticGuitar : Guitar, IAcousticGuitar
    {
        public AcousticGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.StringMaterial = stringMaterial;
            this.CaseIncluded = caseIncluded;
        }
        public bool CaseIncluded { get; private set; }

        public StringMaterial StringMaterial { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(string.Format("Case included: {0}", this.CaseIncluded ? "yes" : "no"));
            sb.AppendLine(string.Format("String material: {0}", this.StringMaterial));
            return sb.ToString();
        }
    }
}
