namespace _9.DirectoriesXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlWriter writer = XmlWriter.Create("../../xml/dirs.xml");
            writer.WriteStartDocument();
            writer.WriteStartElement("root");
            ProcessDirectory("..\\..\\..\\", writer);
            writer.WriteEndElement();
        }

        public static void ProcessDirectory(string targetDirectory, XmlWriter writer)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);

            writer.WriteStartElement("dir");

            foreach (string fileName in fileEntries)
            {
                writer.WriteStartElement("file");
                writer.WriteString(fileName);
                writer.WriteEndElement();
            }

            // Recurse into subDirectories of this directory.
            string[] subDirectoryEntries = Directory.GetDirectories(targetDirectory);

            foreach (string subDirectory in subDirectoryEntries)
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("dirName", subDirectory);
                ProcessDirectory(subDirectory, writer);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
