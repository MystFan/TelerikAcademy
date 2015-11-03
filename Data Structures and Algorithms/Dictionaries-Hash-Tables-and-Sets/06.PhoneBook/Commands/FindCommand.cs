namespace _06.PhoneBook
{
    using System.Collections.Generic;

    public class FindCommand : PhonebookCommand, ICommand<Entry>
    {
        public FindCommand(PhoneBook phoneBook, string name)
            : base(phoneBook)
        {
            this.Name = name;
        }

        public FindCommand(PhoneBook phoneBook, string name, string town)
            : base(phoneBook)
        {
            this.Name = name;
            this.Town = town;
        }

        public string Name { get; set; }

        public string Town { get; set; }

        public string Number { get; set; }

        public override ICollection<Entry> Execute()
        {
            var entries = new HashSet<Entry>();

            if (this.Name != null)
            {
                foreach (var item in this.PhoneBook.EntryByName[this.Name])
                {
                    entries.Add(item);
                }
            }

            if (this.Town != null)
            {
                foreach (var item in this.PhoneBook.EntryByTown[this.Town])
                {
                    entries.Add(item);
                }
            }

            return entries;
        }
    }
}
