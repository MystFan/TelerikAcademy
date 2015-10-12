namespace Phonebook.Contracts
{
    public interface IPhonebookCommand
    {
        void Execute(ICommand command);
    }
}
