namespace _04.ImplementHashTable
{
    using System;
    using HashLibrary;

    public class Startup
    {
        public static void Main()
        {
            HashTable<int, string> table = new HashTable<int, string>();
            
            table.Add(2, "Pesho");
            table.Add(3, "Jhon");
            table.Add(67, "Evlogi");
            table.Add(23, "Jhon");
            table.Add(27, "Pesho");
            table.Add(35, "Jhon");
            table.Add(66, "Evlogi");
            table.Add(11, "Jhon");
            table.Add(32, "Pesho");
            table.Add(19, "Jhon");
            table.Add(12, "Evlogi");
            table.Add(13, "Jhon");
            table.Add(14, "Pesho");
            table.Add(30, "Jhon");
            table.Add(44, "Evlogi");

            foreach (var item in table)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
