namespace _3.ExtractsAllDifferentArtistsWithXPath
{
    using System;
    using System.Xml;
    using System.Collections.Generic;

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

            string xPathQuery = "/albums/album/artist";

            PrintAlbumsCountWithXPath(xmlDocument, xPathQuery, printer);
        }

        private static void PrintAlbumsCountWithXPath(XmlDocument xmlDocument, string xPathQuery, IPrinter printer)
        {
            Dictionary<string, int> nodes = new Dictionary<string, int>();
            var artists = xmlDocument.SelectNodes(xPathQuery);

            foreach (var artist in artists)
            {
                var currentNode = (XmlNode)artist;
                if (!nodes.ContainsKey(currentNode.InnerText))
                {
                    nodes.Add(currentNode.InnerText, 1);
                }
                else
                {
                    var value = nodes[currentNode.InnerText];
                    nodes[currentNode.InnerText] = ++value;
                }
            }

            List<string> results = new List<string>();
            results.Add("With XPath");
            foreach (var node in nodes)
            {
                results.Add(string.Format("Artist: {0}, albums: {1}", node.Key, node.Value));
            }

            printer.Print(results);
        }
    }
}
