namespace Phonebook
{
    using Phonebook.Contracts;

    public class ChangePhoneCommand : IPhonebookCommand
    {
        public ChangePhoneCommand(IPrinter printer, IPhonebookRepository phonebookRepository, IPhoneNumberConvertor converter)
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
            string oldPhoneNumber = this.PhoneConvertor.Convert(command.Parameters[0]);
            string newPhoneNumber = this.PhoneConvertor.Convert(command.Parameters[1]);

            int changedPhones = this.Data.ChangePhone(oldPhoneNumber, newPhoneNumber);

            this.Printer.Print(changedPhones + " numbers changed");
        }
    }
}
