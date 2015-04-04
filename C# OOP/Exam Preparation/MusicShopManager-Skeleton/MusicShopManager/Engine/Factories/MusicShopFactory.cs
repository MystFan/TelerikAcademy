namespace MusicShopManager.Engine.Factories
{
    using System;
    using MusicShopManager.Interfaces;
    using MusicShopManager.Interfaces.Engine;
    using MusicShopManager.Models;

    public class MusicShopFactory : IMusicShopFactory
    {
        public IMusicShop CreateMusicShop(string name)
        {
            IMusicShop musicShop = new MusicShop.Models.MusicShop(name);
            return musicShop;
        }
    }
}
