namespace MusicShopManager.Engine.Factories
{
    using System;
    using MusicShopManager.Interfaces;
    using MusicShopManager.Interfaces.Engine;
    using MusicShopManager.Models;


    public class ArticleFactory : IArticleFactory
    {
        public IMicrophone CreateMirophone(string make, string model, decimal price, bool hasCable)
        {
            IMicrophone microphone = new MusicShop.Models.Microphone(make, model, price, hasCable);
            return microphone;
        }

        public IDrums CreateDrums(string make, string model, decimal price, string color, int width, int height)
        {
            IDrums drums = new MusicShop.Models.Drums(make, model, price, color, width, height);
            return drums;
        }

        public IElectricGuitar CreateElectricGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
        {
            IElectricGuitar guitar = new MusicShop.Models.ElectricGuitar(make, model, price, color, bodyWood, fingerboardWood, numberOfAdapters, numberOfFrets);
            return guitar;
        }

        public IAcousticGuitar CreateAcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
        {
            IAcousticGuitar guitar = new MusicShop.Models.AcousticGuitar(make, model, price, color, bodyWood, fingerboardWood, caseIncluded, stringMaterial);
            return guitar;
        }

        public IBassGuitar CreateBassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
        {
            IBassGuitar guitar = new MusicShop.Models.BassGuitar(make, model, price, color, bodyWood, fingerboardWood);
            return guitar;
        }
    }
}
