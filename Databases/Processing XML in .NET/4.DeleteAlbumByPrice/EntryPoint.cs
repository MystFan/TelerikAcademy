namespace _4.DeleteAlbumByPrice
{
    using System.Collections.Generic;
    using System.Xml;

    using Helpers;
    using Helpers.Contracts;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("../../xml/catalogue.xml");
            var root = xmlDocument.DocumentElement;

            IPrinter printer = new ConsolePrinter();

            int price = 20;
            DeleteByPrice(xmlDocument, price);
            xmlDocument.Save("../../xml/catalogueResultxml");
            printer.Print("Delete succsess!");
        }

        private static void DeleteByPrice(XmlDocument xmlDocument, int price)
        {
            List<XmlNode> childsToRemove = new List<XmlNode>();
            var root = xmlDocument.DocumentElement;
            foreach (var node in root.ChildNodes)
            {
                var currentNode = (XmlNode)node;
                decimal currentNodePrice = decimal.Parse(currentNode["price"].InnerText);
                if (currentNodePrice > price)
                {
                    childsToRemove.Add(currentNode);
                }
            }

            for (int i = 0; i < childsToRemove.Count; i++)
            {
                root.RemoveChild(childsToRemove[i]);
            }
        }
    }
}
