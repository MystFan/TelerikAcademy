namespace _06.PhoneBook
{
    using System.Collections.Generic;

    public interface ICommand<T>
    {
        ICollection<T> Execute();
    }
}
