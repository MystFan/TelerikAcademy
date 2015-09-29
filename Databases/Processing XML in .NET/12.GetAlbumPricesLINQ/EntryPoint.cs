namespace _12.GetAlbumPricesLINQ
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            XDocument xmlDocument = XDocument.Load("../../xml/catalogue.xml");

            int spanYears = 5;
            var year = DateTime.Now.Year - spanYears;

            var prices =
                from album in xmlDocument.Descendants("album")
                where int.Parse(album.Element("year").Value) <= year
                select album.Element("price");

            var pricesNode = new XElement("prices");
            foreach (var price in prices)
            {
                var currentAlbum = (XElement)price;
                var currentPrice = new XElement("price", currentAlbum.Value);
                pricesNode.Add(currentPrice);
            }

            pricesNode.Save("../../xml/prices.xml");
            Console.WriteLine("prices.xml success!");
        }
    }
}
