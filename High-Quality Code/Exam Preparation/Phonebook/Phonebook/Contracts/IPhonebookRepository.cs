﻿namespace Phonebook.Contracts
{
    using System.Collections.Generic;

    public interface IPhonebookRepository
    {
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);

        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);

        IEnumerable<Entry> ListEntries(int startIndex, int count);
    }
}
