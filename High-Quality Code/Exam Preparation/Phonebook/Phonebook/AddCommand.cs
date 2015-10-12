namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Phonebook.Contracts;

    public class AddCommand : IPhonebookCommand
    {
        public AddCommand(IPrinter printer, IPhonebookRepository phonebookRepository, IPhoneNumberConvertor converter)
        {
            this.Printer = printer;
            this.Data = phonebookRepository;
            this.PhoneConvertor = converter;
        }

        public IPrinter Printer { get; set; }

        public IPhonebookRepository Data { get; set; }

        internal IPhoneNumberConvertor PhoneConvertor { get; set; }

        public void Execute(ICommand command)
        {
            string ownerName = command.Parameters[0];
            var phoneNumbers = command.Parameters.Skip(1).ToList();

            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                phoneNumbers[i] = this.PhoneConvertor.Convert(phoneNumbers[i]).Trim();
            }

            bool isPhonesAdded = this.Data.AddPhone(ownerName, phoneNumbers);

            if (isPhonesAdded)
            {
                this.Printer.Print("Phone entry created");
            }
            else
            {
                this.Printer.Print("Phone entry merged");
            }
        }
    }
}
