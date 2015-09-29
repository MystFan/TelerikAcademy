namespace _6.GetSongsTitlesWithXDocument
{
    using System.Xml;
    using System.Linq;
    using System.Xml.Linq;
    using System.Collections.Generic;

    using Helpers;
    using Helpers.Contracts;

    public class EntryPoint
    {
        public static void Main()
        {
            XDocument xmlDocument = XDocument.Load("../../xml/catalogue.xml");

            var songs =
                from album in xmlDocument.Descendants("album")
                select album.Element("songs");

            var titles =
                from song in songs.Descendants("song")
                select song.Element("title").Value;

            IPrinter printer = new ConsolePrinter();
            printer.Print(titles);
        }
    }
}
