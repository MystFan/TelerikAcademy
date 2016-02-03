namespace ASP.NET_MVC_Essentials.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private Dictionary<string, string> result;

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Calculator()
        {
            result = new Dictionary<string, string>();
            return View(result);
        }

        [ActionName("Calculator")]
        [HttpPost]
        public ActionResult Calculator_Post()
        {
            Dictionary<string, decimal> dic1024Bit = new Dictionary<string, decimal>()
            {
                {"bit - b",1},
                {"Byte - B",(decimal)Math.Pow(2,3)},
                {"Kilobit - Kb", (decimal)Math.Pow(2,10)},
                {"Kilobyte - KB",(decimal)Math.Pow(2,13)},
                {"Megabit - Mb",(decimal)Math.Pow(2,20)},
                {"Megabyte - MB",(decimal)Math.Pow(2,23)},
                {"Gigabit - Gb",(decimal)Math.Pow(2,30)},
                {"Gigabyte - GB",(decimal)Math.Pow(2,33)},
                {"Terabit - Tb",(decimal)Math.Pow(2,40)},
                {"Terabyte - TB",(decimal)Math.Pow(2,43)},
                {"Petabit - Pb",(decimal)Math.Pow(2,50)},
                {"Petabyte - PB",(decimal)Math.Pow(2,53)},
                {"Exabit - Eb",(decimal)Math.Pow(2,60)},
                {"Exabyte - EB",(decimal)Math.Pow(2,63)},
                {"Zettabit - Zb",(decimal)Math.Pow(2,70)},
                {"Zettabyte - ZB",(decimal)Math.Pow(2,73)},
                {"Yottabit - Yb",(decimal)Math.Pow(2,80)},
                {"Yottabyte - YB",(decimal)Math.Pow(2,83)}
            };

            Dictionary<string, decimal> dic1000Bit = new Dictionary<string, decimal>()
            {
                {"bit - b",1},
                {"Byte - B",(decimal)Math.Pow(2,3)},
                {"Kilobit - Kb", (decimal)Math.Pow(10,3)},
                {"Kilobyte - KB",((decimal)Math.Pow(10,3))*8},
                {"Megabit - Mb",(decimal)Math.Pow(10,6)},
                {"Megabyte - MB",((decimal)Math.Pow(10,6))*8},
                {"Gigabit - Gb",(decimal)Math.Pow(10,9)},
                {"Gigabyte - GB",((decimal)Math.Pow(10,9))*8},
                {"Terabit - Tb",(decimal)Math.Pow(10,12)},
                {"Terabyte - TB",((decimal)Math.Pow(10,12))*8},
                {"Petabit - Pb",(decimal)Math.Pow(10,15)},
                {"Petabyte - PB",((decimal)Math.Pow(10,15))*8},
                {"Exabit - Eb",(decimal)Math.Pow(10,18)},
                {"Exabyte - EB",((decimal)Math.Pow(10,18))*8},
                {"Zettabit - Zb",(decimal)Math.Pow(10,21)},
                {"Zettabyte - ZB",((decimal)Math.Pow(10,21))*8},
                {"Yottabit - Yb",(decimal)Math.Pow(10,24)},
                {"Yottabyte - YB",((decimal)Math.Pow(10,24))*8}
            };

            result = new Dictionary<string, string>();

            var quantity = Request.Form["quantity"] != null ? decimal.Parse(Request.Form["quantity"]) : 1m;
            var type = Request.Form["type"];
            var kilo = decimal.Parse(Request.Form["kilo"]);

            decimal currentBit = 0;
            decimal currentByte = 0;
            if (kilo == 1000m)
            {
                currentBit = dic1000Bit.Where(d => d.Key == type).FirstOrDefault().Value * quantity;
            }
            if (kilo == 1024m)
            {
                currentBit = dic1024Bit.Where(d => d.Key == type).FirstOrDefault().Value * quantity;
            }

            currentByte = currentBit / 8;
            result.Add("bit - b", currentBit.ToString());
            result.Add("Byte - B", currentByte.ToString());
            var i = 1;

            foreach (var item in dic1024Bit)
            {
                if (i > 2)
                {
                    if (i % 2 == 0)
                    {
                        currentByte = currentBit / 8;
                        result.Add(item.Key, currentByte.ToString());
                    }
                    if (i % 2 != 0)
                    {
                        currentBit /= kilo;
                        result.Add(item.Key, currentBit.ToString());
                    }
                }

                i++;
            }

            return View(result);
        }
    }
}