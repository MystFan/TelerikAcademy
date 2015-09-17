using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DocumentCompiler : IDocumentCompiler
    {
        private IDocument document;

        public DocumentCompiler(IDocument document)
        {
            this.Document = document;
        }

        public IDocument Document
        {
            get
            {
                return this.document;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.document = value;
            }
        }

        public string BuildDocument(string headerTitle, string[] headerContent, string[] bodyContent, string[] footerContent)
        {
            string resultDocument = this.document.CreateHeader(headerTitle, headerContent) + "\n";
            resultDocument += this.document.CreateBody(bodyContent) + "\n";
            resultDocument += this.document.CreateFooter(footerContent);

            return resultDocument;
        }
    }
}
