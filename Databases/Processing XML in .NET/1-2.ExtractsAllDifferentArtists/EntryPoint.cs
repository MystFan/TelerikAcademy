namespace _2.ExtractsAllDifferentArtists
{
    using System;
    using System.Xml;
    using System.Collections;
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

            PrintAlbumsCount(root, printer);
        }

        private static void PrintAlbumsCount(XmlElement root, IPrinter printer)
        {
            var albums = GetUniqueNodes(root, "artist");

            List<string> results = new List<string>();
            foreach (var album in albums)
            {
                var albumCount = GetAlbumsCount(album["artist"].InnerText, root);
                results.Add(string.Format("Artist: {0}, albums: {1}", album["artist"].InnerText, albumCount));
            }

            printer.Print(results);
        }

        public static int GetAlbumsCount(string nodeValue, XmlNode root)
        {
            int counter = 0;
            foreach (var item in root.ChildNodes)
            {
                var currentNode = ((XmlNode)item);
                if (currentNode["artist"].InnerText == nodeValue)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static List<XmlNode> GetUniqueNodes(XmlNode root, string nodeName)
        {
            List<XmlNode> results = new List<XmlNode>();

            Hashtable ht = new Hashtable();

            foreach (var node in root.ChildNodes)
            {
                var currentNode = ((XmlNode)node);
                if (!ht.ContainsKey(currentNode[nodeName].InnerText))
                {
                    ht.Add(currentNode[nodeName].InnerText, currentNode);
                }
            }

            foreach (var item in ht)
            {
                var entry = (DictionaryEntry)item;
                results.Add((XmlNode)entry.Value);
            }

            return results;
        }
    }
}
