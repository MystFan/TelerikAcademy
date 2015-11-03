namespace HashLibrary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
        where K : IComparable
        where T : IComparable
    {
        private const int InitialCapacity = 17;
        private LinkedList<KeyValuePair<K, T>>[] elements;

        public HashTable()
        {
            this.elements = new LinkedList<KeyValuePair<K, T>>[InitialCapacity];
        }

        public int Count { get; private set; }

        public int Capacity 
        {
            get
            {
                return this.elements.Length;
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                List<K> keys = new List<K>();

                foreach (var element in this.elements)
                {
                    if (element != null)
                    {
                        foreach (var item in element)
                        {
                            keys.Add(item.Key);
                        }
                    }
                }

                return keys.AsEnumerable<K>();
            }
        }

        public T this[K key]
        {
            get
            {
                T resultItem = default(T);
                int position = this.GetHash(key);

                if (this.elements[position] == null)
                {
                    throw new KeyNotFoundException("The given key was not present in the hash table.");
                }

                foreach (var item in this.elements[position])
                {
                    if (item.Key.Equals(key))
                    {
                        resultItem = item.Value;
                    }
                }

                return resultItem;
            }

            set
            {
                int position = this.GetHash(key);

                if (this.elements[position] == null)
                {
                    throw new KeyNotFoundException("The given key was not present in the hash table.");
                }

                this.elements[position].Last.Value = new KeyValuePair<K, T>(key, value);
            }
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var element in this.elements)
            {
                if (element != null)
                {
                    foreach (var item in element)
                    {
                        yield return item;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public T Find(K key)
        {
            int position = this.GetHash(key);

            T value = default(T);
            foreach (var item in this.elements[position])
            {
                if (item.Key.Equals(key))
                {
                    value = item.Value;
                }
            }

            return value;
        }

        public void Add(K key, T value)
        {
            int position = this.GetHash(key);

            if (this.elements[position] == null)
            {
                this.elements[position] = new LinkedList<KeyValuePair<K, T>>();
            }

            var isKeyContains = this.elements[position].Any(p => p.Key.Equals(key));

            if (isKeyContains)
            {
                throw new ArgumentException("Key already exist in table");
            }

            var pair = new KeyValuePair<K, T>(key, value);

            this.elements[position].AddLast(pair);
            this.Count++;

            if (this.MustResize())
            {
                this.Resize();
            }
        }

        public void Remove(K key)
        {
            int position = this.GetHash(key);

            foreach (var item in this.elements[position])
            {
                if (item.Key.Equals(key))
                {
                    this.elements[position].Remove(item);
                    this.Count--;
                    break;
                }
            }
        }

        public void Clear()
        {
            this.elements = new LinkedList<KeyValuePair<K, T>>[InitialCapacity];
            this.Count = 0;
        }

        private int GetHash(K key)
        {
            int hash = key.GetHashCode() % this.elements.Length;
            return Math.Abs(hash);
        }

        private bool MustResize()
        {
            return this.Count >= 0.75 * this.Capacity;
        }

        private void Resize()
        {
            IEnumerable<KeyValuePair<K, T>>[] tableCells = this.elements;
            this.elements = new LinkedList<KeyValuePair<K, T>>[this.Capacity * 2];

            this.Count = 0;

            foreach (var cell in tableCells)
            {
                if (cell != null)
                {
                    foreach (var item in cell)
                    {
                        this.Add(item.Key, item.Value);
                    }
                }
            }
        }
    }
}
