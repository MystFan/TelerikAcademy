namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class CommandManager : ICommandManager
    {
        private IPhonebookRepository phonebookRepository;

        public CommandManager(IPhonebookRepository phonebookRepository, IPrinter printer, IPhoneNumberConvertor converter)
        {
            this.PhonebookRepository = phonebookRepository;
            this.Printer = printer;
            this.PhoneConverter = converter;
        }

        public IPhonebookRepository PhonebookRepository
        {
            get
            {
                return this.phonebookRepository;
            }

            private set
            {
                this.phonebookRepository = value;
            }
        }

        public IPhoneNumberConvertor PhoneConverter { get; set; }

        public IPrinter Printer { get; set; }

        public string ProceedCommand(Command command)
        {
            string result = string.Empty;
            IPhonebookCommand cmd = null;

            if (command.Name == "AddPhone")
            {
                cmd = new AddCommand(this.Printer, this.PhonebookRepository, this.PhoneConverter);
            }
            else if (command.Name == "ChangePhone")
            {
                cmd = new ChangePhoneCommand(this.Printer, this.PhonebookRepository, this.PhoneConverter);
            }
            else if (command.Name == "List")
            {
                cmd = new ListCommand(this.Printer, this.PhonebookRepository);
            }

            cmd.Execute(command);

            return result;
        }
    }
}
