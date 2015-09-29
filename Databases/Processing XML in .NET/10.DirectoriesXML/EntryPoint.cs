namespace _10.DirectoriesXML
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            string[] directories = Directory.GetDirectories("..\\..\\..\\");
            XElement document = new XElement("directories");
            CreateXML(directories, document);
            document.Save("../../dirs.xml");
        }

        private static void CreateXML(string[] dirs, XElement doc)
        {
            foreach (string directory in dirs)
            {
                var currentDirectory = new XElement("dir");
                currentDirectory.Add(new XAttribute("directoryName", directory));

                if (currentDirectory == null)
                {
                    return;
                }

                foreach (var file in Directory.EnumerateFiles(directory, "*.*"))
                {
                    currentDirectory.Add(new XElement("file", file));
                }

                doc.Add(currentDirectory);

                CreateXML(Directory.GetDirectories(directory), currentDirectory);
            }
        }
    }
}
