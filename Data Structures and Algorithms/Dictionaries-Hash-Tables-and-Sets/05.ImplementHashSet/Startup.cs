namespace _05.ImplementHashSet
{
    using System;
    using System.Collections.Generic;
    using HashLibrary;

    public class Startup
    {
        public static void Main()
        {
            HashedSet<string> hashedSet = new HashedSet<string>();
            for (int i = 0; i < 5; i++)
            {
                hashedSet.Add("item " + i);
            }

            var set = new List<string> { "item 3", "item 5" };
            var unionSet = hashedSet.Union(set);
            var intersectSet = hashedSet.Intersect(set);

            Console.WriteLine("Union: {0}", string.Join(", ", unionSet));
            Console.WriteLine("Intersect: {0}", string.Join(", ", intersectSet));
        }
    }
}
