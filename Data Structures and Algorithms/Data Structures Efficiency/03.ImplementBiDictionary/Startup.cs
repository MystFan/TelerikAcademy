namespace _03.ImplementBiDictionary
{
    using System;

    public class Startup
    {
        private static Random Random = new Random((int)DateTime.Now.Ticks);

        public static void Main()
        {
            BiDictionary<decimal, int, int> biDictionary = new BiDictionary<decimal, int, int>();
            for (int i = 0; i < 500; i++)
            {
                decimal key1 = RandomNumber(1, 6);
                int key2 = RandomNumber(1, 6);
                int value = Random.Next(1, 1000);
                biDictionary.Add(key1, key2, value);
            }

            var firstKeyResults = biDictionary.FindByFirstKey(2);
            var secondKeyResults = biDictionary.FindBySecondKey(4);
            var twoKeysResult = biDictionary.FindByTwoKeys(2, 4);
        }

        private static int RandomNumber(int min, int max)
        {
            return Random.Next(min, max);
        }
    }
}
