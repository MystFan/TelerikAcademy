namespace Phonebook
{
    using System.Linq;
    using Phonebook.Contracts;

    public class ListCommand : IPhonebookCommand
    {
        public ListCommand(IPrinter printer, IPhonebookRepository phonebookRepository)
        {
            this.Printer = printer;
            this.Data = phonebookRepository;
        }

        public IPrinter Printer { get; set; }

        public IPhonebookRepository Data { get; set; }

        public void Execute(ICommand command)
        {
            try
            {
                int startIndex = int.Parse(command.Parameters[0]);
                int count = int.Parse(command.Parameters[1]);
                var entryList = this.Data.ListEntries(startIndex, count);

                if (entryList.Count() == 0)
                {
                    this.Printer.Print("Invalid range");
                }
                else
                {
                    this.Printer.Print(string.Join("\n", entryList));
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                this.Printer.Print("Invalid range");
            }
        }
    }
}
