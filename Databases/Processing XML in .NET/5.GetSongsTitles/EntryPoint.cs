namespace _5.GetSongsTitles
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

            List<string> songTitles = new List<string>();
            var element = string.Empty;
            using (reader)
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "song")
                    {
                        element = "song";
                        continue;
                    }

                    if (element == "song" && reader.NodeType == XmlNodeType.Text)
                    {
                        songTitles.Add(reader.Value);
                        element = string.Empty;
                    }
                }
            }

            IPrinter printer = new ConsolePrinter();
            printer.Print(songTitles);
        }
    }
}
