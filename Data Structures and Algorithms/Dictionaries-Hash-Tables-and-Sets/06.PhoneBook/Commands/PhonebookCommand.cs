namespace _06.PhoneBook
{
    using System.Collections.Generic;

    public abstract class PhonebookCommand : ICommand<Entry>
    {
        protected readonly PhoneBook PhoneBook;

        public PhonebookCommand(PhoneBook phoneBook)
        {
            this.PhoneBook = phoneBook;
        }

        public abstract ICollection<Entry> Execute();
    }
}
