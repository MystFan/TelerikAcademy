namespace HashLibrary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashedSet<T> : IEnumerable<T>
        where T : IComparable
    {
        private HashTable<T, bool> table;

        public HashedSet()
        {
            this.table = new HashTable<T, bool>();
        }

        public int Count 
        {
            get
            {
                return this.table.Count;
            }
        }

        public void Add(T value)
        {
            if (this.table.Keys.Contains(value))
            {
                return;
            }

            this.table.Add(value, true);
        }

        public bool Find(T value)
        {
            return this.table.Keys.Contains(value);
        }

        public void Remove(T value)
        {
            if (!this.table.Keys.Contains(value))
            {
                return;
            }

            this.table.Remove(value);
        }

        public void Clear()
        {
            this.table.Clear();
        }

        public IEnumerable<T> Union(IEnumerable<T> otherCollection)
        {
            List<T> resultCollection = new List<T>();
            var keys = this.table.Keys;

            foreach (var item in otherCollection)
            {
                if (!keys.Contains(item))
                {
                    resultCollection.Add(item);
                }
            }

            foreach (var key in keys)
            {
                resultCollection.Add(key);
            }

            return resultCollection.AsEnumerable();
        }

        public IEnumerable<T> Intersect(IEnumerable<T> otherCollection)
        {
            List<T> resultCollection = new List<T>();
            var keys = this.table.Keys;

            foreach (var item in otherCollection)
            {
                if (keys.Contains(item))
                {
                    resultCollection.Add(item);
                }
            }

            return resultCollection.AsEnumerable();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var keys = this.table.Keys;
            foreach (var key in keys)
            {
                yield return key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
