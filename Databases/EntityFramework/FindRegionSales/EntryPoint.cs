namespace FindRegionSales
{
    using System;
    using System.Linq;
    using EntityFrameworkNorthwind;

    public class EntryPoint
    {
        public static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();

            string regionName = "RJ";
            DateTime startDate = new DateTime(1996, 7, 16);
            DateTime endDate = new DateTime(1997, 5, 6);

            using (db)
            {

                var sales = db.Orders
                    .Where(o =>  startDate <= o.ShippedDate && endDate >= o.ShippedDate && o.ShipRegion == regionName)
                    .ToList();

                foreach (var sale in sales)
                {
                    Console.WriteLine(string.Format("{0} -> {1}", sale.ShipRegion, sale.ShippedDate));
                }
            }
        }
    }
}
