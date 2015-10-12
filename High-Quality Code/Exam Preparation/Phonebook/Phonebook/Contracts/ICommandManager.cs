namespace Phonebook.Contracts
{
    public interface ICommandManager
    {
        IPhonebookRepository PhonebookRepository { get; }

        string ProceedCommand(Command command);
    }
}
