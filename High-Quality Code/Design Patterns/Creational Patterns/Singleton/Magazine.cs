using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Patterns
{
    public class Magazine : IReadable
    {

        public string Title { get; set; }

        public string Publisher { get; set; }

        public override string ToString()
        {
            return "title: '" + this.Title + "' publisher: " + this.Publisher;
        }

    }
}
