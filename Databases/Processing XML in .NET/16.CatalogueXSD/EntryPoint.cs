namespace _16.CatalogueXSD
{
    using System;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;

    using Helpers;
    using Helpers.Contracts;
    using System.Collections.Generic;
    public class EntryPoint
    {
        public static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("urn:catalogue", "..//..//xml/catalogue.xsd");

            XDocument XmlDocument = XDocument.Load("..//..//xml/catalogue.xml");

            List<string> errorMessages = new List<string>();

            XmlDocument.Validate(schemas, (obj, error) =>
            {
                errorMessages.Add(error.Message);
            });

            IPrinter printer = new ConsolePrinter();

            if (errorMessages.Count == 0)
            {
                printer.Print("Valid catalogue.xml");
            }
            else
            {
                printer.Print(errorMessages);
            }
        }
    }
}
