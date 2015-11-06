namespace _03.ImplementBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BiDictionary<K1, K2, V>
        where K1 : IComparable
        where K2 : IComparable
        where V : IComparable
    {
        private const int InitialCapacity = 17;
        private LinkedList<Tuple<K1, K2, V>>[] firstCollection;
        private LinkedList<Tuple<K1, K2, V>>[] secondCollection;

        public BiDictionary()
        {
            this.firstCollection = new LinkedList<Tuple<K1, K2, V>>[InitialCapacity];
            this.secondCollection = new LinkedList<Tuple<K1, K2, V>>[InitialCapacity];
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.firstCollection.Length;
            }
        }

        public void Add(K1 firstKey, K2 secondKey, V value)
        {
            int firstKeyPosition = this.GetK1Hash(firstKey);
            int secondKeyPosition = this.GetK2Hash(secondKey);

            if (this.firstCollection[firstKeyPosition] == null)
            {
                this.firstCollection[firstKeyPosition] = new LinkedList<Tuple<K1, K2, V>>();
            }

            if (this.secondCollection[secondKeyPosition] == null)
            {
                this.secondCollection[secondKeyPosition] = new LinkedList<Tuple<K1, K2, V>>();
            }

            var firstPair = new Tuple<K1, K2, V>(firstKey, secondKey, value);
            var secondPair = new Tuple<K1, K2, V>(firstKey, secondKey, value);

            this.firstCollection[firstKeyPosition].AddLast(firstPair);
            this.secondCollection[secondKeyPosition].AddLast(secondPair);
            this.Count++;

            if (this.MustResize())
            {
                this.Resize();
            }
        }

        public void Clear()
        {
            this.firstCollection = new LinkedList<Tuple<K1, K2, V>>[InitialCapacity];
            this.secondCollection = new LinkedList<Tuple<K1, K2, V>>[InitialCapacity];
            this.Count = 0;
        }

        private int GetK1Hash(K1 key)
        {
            int hash = key.GetHashCode() % this.firstCollection.Length;
            return Math.Abs(hash);
        }

        private int GetK2Hash(K2 key)
        {
            int hash = key.GetHashCode() % this.secondCollection.Length;
            return Math.Abs(hash);
        }

        private bool MustResize()
        {
            return this.Count >= 0.75 * this.Capacity;
        }

        private void Resize()
        {
            LinkedList<Tuple<K1, K2, V>>[] currentFirstCollection = this.firstCollection;
            this.firstCollection = new LinkedList<Tuple<K1, K2, V>>[this.Capacity * 2];
            LinkedList<Tuple<K1, K2, V>>[] currentSecondCollection = this.secondCollection;
            this.secondCollection = new LinkedList<Tuple<K1, K2, V>>[this.Capacity * 2];
            this.Count = 0;

            for (int i = 0; i < currentFirstCollection.Length; i++)
            {
                this.firstCollection[i] = currentFirstCollection[i];
            }

            for (int i = 0; i < currentSecondCollection.Length; i++)
            {
                this.secondCollection[i] = currentSecondCollection[i];
            }
        }

        public ICollection<V> FindByFirstKey(K1 key)
        {
            int position = this.GetK1Hash(key);

            if (this.firstCollection[position] == null)
            {
                throw new KeyNotFoundException("The given key was not present in the dictionary.");
            }

            ICollection<V> result = new HashSet<V>();
            foreach (var item in this.firstCollection[position])
            {
                if (item.Item1.Equals(key))
                {
                    result.Add(item.Item3);
                }
            }

            return result;
        }

        public ICollection<V> FindBySecondKey(K2 key)
        {
            int position = this.GetK2Hash(key);

            if(this.secondCollection[position] == null)
            {
                throw new KeyNotFoundException("The given key was not present in the dictionary.");
            }

            ICollection<V> result = new HashSet<V>();
            foreach (var item in this.secondCollection[position])
            {
                if (item.Item2.Equals(key))
                {
                    result.Add(item.Item3);
                }
            }

            return result;
        }

        public ICollection<V> FindByTwoKeys(K1 firstKey, K2 secondKey)
        {
            int secondPosition = this.GetK2Hash(secondKey);

            if (this.secondCollection[secondPosition] == null)
            {
                throw new KeyNotFoundException("The given key was not present in the dictionary.");
            }

            ICollection<V> result = new HashSet<V>();
            foreach (var item in this.secondCollection[secondPosition])
            {
                if (item.Item2.Equals(secondKey) && item.Item1.Equals(firstKey))
                {
                    result.Add(item.Item3);
                }
            }

            return result.ToList();
        }
    }
}
