namespace _11.GetAlbumPrices
{
    using System.Xml;
    using System;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("../../xml/catalogue.xml");
            var root = xmlDocument.DocumentElement;

            int spanYears = 5;
            var year = (DateTime.Now).Year - spanYears;
            string xPathQuery = "/albums/album[year<=" + year + "]/price";

            var prices = xmlDocument.SelectNodes(xPathQuery);

            var pricesNode = new XElement("prices");
            foreach (var price in prices)
            {
                var currentAlbum = (XmlElement)price;
                var currentPrice = new XElement("price", currentAlbum.InnerText);
                pricesNode.Add(currentPrice);
            }

            pricesNode.Save("../../xml/prices.xml");
            Console.WriteLine("prices.xml success!");
        }
    }
}
