using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main()
        {
            string title = "Strategy pattern !!!";
            string[] headerContent = new string[]
            {
                "<> Main purpose:"
            };

            string[] bodyContent = new string[]
            {
                "Encapsulate a family of related algorithms",
                "Let the algorithm vary and evolve separate from the class using it",
                "Allow a class to maintain a single purpose",
                "Separate the calculation from the delivery of its results"
            };

            string[] footerContent = new string[]
            {
                "Telerik Academy - Strategy Patterns lecture"
            };

            RegularDocument regularDoc = new RegularDocument();
            DocumentCompiler dc = new DocumentCompiler(regularDoc);
            string regularDocumentResult = dc.BuildDocument(title, headerContent, bodyContent, footerContent);
            Console.WriteLine("Regular document");
            Console.WriteLine(regularDocumentResult);
            Console.WriteLine();

            SpecialDocument specialDoc = new SpecialDocument(20);
            dc = new DocumentCompiler(specialDoc);
            string specialDocumentResult = dc.BuildDocument(title, headerContent, bodyContent, footerContent);
            Console.WriteLine("Special document");
            Console.WriteLine(specialDocumentResult);
        }
    }
}
