namespace _7.CreatePersonsXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            var persons = GetPersons("../../persons.txt");
            GenerateXMLDocument(persons);
        }

        private static void GenerateXMLDocument(IEnumerable<Person> persons)
        {
            XElement xElement = new XElement("persons");
            foreach (var person in persons)
            {
                XElement personNode = new XElement("person");
                personNode.Add(new XElement("name", person.Name));
                personNode.Add(new XElement("address", person.Address));
                personNode.Add(new XElement("phone", person.PhoneNumber));
                xElement.Add(personNode);
            }

            xElement.Save("../../persons.xml");
        }

        private static List<Person> GetPersons(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<Person> persons = new List<Person>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] personData = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person(personData[0], personData[1], personData[2]);
                    persons.Add(person);
                    line = reader.ReadLine();
                }
            }

            return persons;
        }
    }
}
