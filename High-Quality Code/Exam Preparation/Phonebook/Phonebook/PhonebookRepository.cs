namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Phonebook.Contracts;
    using Wintellect.PowerCollections;

    public class PhonebookRepository : IPhonebookRepository
    {
        private OrderedSet<Entry> sortedEntries = new OrderedSet<Entry>();
        private Dictionary<string, Entry> dictionaryEntries = new Dictionary<string, Entry>();
        private MultiDictionary<string, Entry> multidictionaryEntries = new MultiDictionary<string, Entry>(false);

        public bool AddPhone(string name, IEnumerable<string> phoneNumbers)
        {
            string nameLowerCase = name.ToLowerInvariant();
            Entry entry; 
            bool exist = !this.dictionaryEntries.TryGetValue(nameLowerCase, out entry);

            if (exist)
            {
                entry = new Entry();
                entry.Name = name;
                entry.Phones = new SortedSet<string>();
                this.dictionaryEntries.Add(nameLowerCase, entry);
                this.sortedEntries.Add(entry);
            }

            foreach (var number in phoneNumbers)
            {
                this.multidictionaryEntries.Add(number, entry);
            }

            entry.Phones.UnionWith(phoneNumbers);
            return exist;
        }

        public int ChangePhone(string oldEntity, string newEntity)
        {
            var foundedEntry = this.multidictionaryEntries[oldEntity].ToList();
            foreach (var entry in foundedEntry)
            {
                entry.Phones.Remove(oldEntity);
                this.multidictionaryEntries.Remove(oldEntity, entry);
                entry.Phones.Add(newEntity); 
                this.multidictionaryEntries.Add(newEntity, entry);
            }

            return foundedEntry.Count;
        }

        public IEnumerable<Entry> ListEntries(int startIndex, int count)
        {
            if (startIndex < 0 || startIndex + count > this.dictionaryEntries.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            Entry[] matchedEntries = new Entry[count];
            for (int i = startIndex; i <= startIndex + count - 1; i++)
            {
                Entry entry = this.sortedEntries[i];
                matchedEntries[i - startIndex] = entry;
            }

            return matchedEntries;
        }
    }
}
