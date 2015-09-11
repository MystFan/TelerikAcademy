namespace CompositePattern
{
    using System;

    public class CompositePattern
    {
        public static void Main()
        {
            var mainDocument = new Document("Moment.js");
            mainDocument.AddAttribute("class", "container");

            var nodejs = new Document("Node.js");
            nodejs.Add(new Paragraph("Node.js", "npm install moment var moment; var moment = require('moment');"));
            mainDocument.Add(nodejs);

            var browser = new Document("Browser");
            var doc = new Document("HTML");
            doc.Add(new Paragraph("browser", "<script src=\"moment.js\"></script>"));
            browser.Add(doc);
            mainDocument.Add(browser);

            var packageManagers = new Document("Package managers");
            var bower = new Paragraph("bower", "bower install --save moment");
            packageManagers.Add(bower);
            var nugetGet = new Paragraph("NuGet", "Install-Package Moment.js");
            packageManagers.Add(nugetGet);
            var meteor = new Paragraph("meteor", "meteor add momentjs:moment");
            packageManagers.Add(meteor);
            mainDocument.Add(packageManagers);

            var requirejs = new Document("Require.js");
            requirejs.Add(new Paragraph("require.js", "define([\"path/to/moment\"], function (moment) { moment().format();});"));
            mainDocument.Add(requirejs);

            var result = mainDocument.Display(1);
            Console.WriteLine("Moment.js Documentation");
            Console.WriteLine(result);
        }
    }
}
