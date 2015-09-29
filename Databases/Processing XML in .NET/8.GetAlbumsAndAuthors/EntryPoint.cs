namespace _8.GetAlbumsAndAuthors
{
    using System.Xml;
    using System.Collections.Generic;

    using Helpers;
    using Helpers.Contracts;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlReader reader = XmlReader.Create("../../xml/catalogue.xml");
            XmlWriter writer = XmlWriter.Create("../../xml/album.xml");

            using (reader)
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");
                bool inAlbum = false;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && (reader.Name == "album"))
                    {
                        inAlbum = true;
                        continue;
                    }

                    if (reader.NodeType == XmlNodeType.Element && inAlbum && (reader.Name == "name"))
                    {
                        writer.WriteStartElement("album");
                        writer.WriteElementString(reader.Name, reader.ReadInnerXml());
                        reader.ReadToNextSibling("artist");
                        writer.WriteElementString(reader.Name, reader.ReadInnerXml());
                        writer.WriteEndElement();
                        inAlbum = false;
                    }
                }
            }

            writer.WriteEndElement();
            writer.Dispose();
        }
    }
}
