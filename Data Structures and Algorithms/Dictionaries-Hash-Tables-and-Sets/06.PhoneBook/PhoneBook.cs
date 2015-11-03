namespace _06.PhoneBook
{
    using System.Collections.Generic;
    using System.Linq;

    public class PhoneBook
    {
        public readonly Dictionary<string, List<Entry>> EntryByTown;
        public readonly Dictionary<string, List<Entry>> EntryByName;

        public PhoneBook()
        {
            this.Entries = new List<Entry>();
            this.EntryByName = new Dictionary<string, List<Entry>>();
            this.EntryByTown = new Dictionary<string, List<Entry>>();
        }

        public IList<Entry> Entries { get; set; }

        public void Add(Entry entry)
        {
            this.Entries.Add(entry);

            if (!this.EntryByName.Keys.Contains(entry.Name))
            {
                this.EntryByName[entry.Name] = new List<Entry>();
            }

            if (!this.EntryByTown.Keys.Contains(entry.Town))
            {
                this.EntryByTown[entry.Town] = new List<Entry>();
            }

            this.EntryByName[entry.Name].Add(entry);
            this.EntryByTown[entry.Town].Add(entry);
        }
    }
}
