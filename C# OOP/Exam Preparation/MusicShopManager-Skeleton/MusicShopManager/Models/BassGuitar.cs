

namespace MusicShop.Models
{
    using System;
    using MusicShopManager.Interfaces;
    public class BassGuitar : Guitar, IBassGuitar
    {
        private const int GenerallyBassGuitarNumberOfStrings = 4;
             
        public BassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.NumberOfStrings = BassGuitar.GenerallyBassGuitarNumberOfStrings;
            this.IsElectronic = true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
