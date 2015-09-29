namespace _13.CreateXSLStylesheet
{
    using System;
    using System.Xml.Xsl;

    public class EntryPoint
    {
        public static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("..\\..\\catalogue.xslt");
            xslt.Transform("..\\..\\xml\\catalogue.xml", "..\\..\\html\\catalogue.html");
        }
    }
}
