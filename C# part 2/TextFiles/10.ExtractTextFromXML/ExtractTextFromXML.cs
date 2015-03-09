/*
 Problem 10. Extract text from XML

    Write a program that extracts from given XML file all the text without the tags.

Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
 */
namespace _10.ExtractTextFromXML
{
    using System;
    using System.IO;
    using System.Text;
    class ExtractTextFromXML
    {
        static void Main()
        {
            string path = @"..\..\html.txt";
            Console.WriteLine(ExtractTextFromXMLDocument(path));
        }

        private static string ExtractTextFromXMLDocument(string path)
        {
            StreamReader reader = new StreamReader(path);
            StringBuilder html = new StringBuilder();

            using (reader)
            {
                string line = reader.ReadLine();
                int start = -1;
                while (line != null)
                {
                    start = -1;
                    while (true)
                    {
                        start = line.IndexOf(">", start + 1);
                        if (start == -1)
                        {
                            break;
                        }
                        for (int i = start + 1; i < line.Length; i++)
                        {
                            if (line[i] == '<')
                            {
                                html.Append(" ");
                                break;
                            }
                            html.Append(line[i]);
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            return html.ToString();
        }
    }
}
