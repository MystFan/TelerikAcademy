
namespace MusicShop.Models
{
    using MusicShopManager.Interfaces;
    using System.Text;
    public class Microphone : Article, IMicrophone
    {
        public Microphone(string make, string model, decimal price, bool hasCable)
            : base(make, model, price)
        {
            this.HasCable = hasCable;
        }
        public bool HasCable { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("= {0} {1} =", this.Make, this.Model));
            sb.AppendLine(string.Format("Price: ${0:F2}", this.Price));
            sb.AppendLine(string.Format("Cable: {0}", this.HasCable ? "yes" : "no"));
            return sb.ToString();
        }
    }
}
