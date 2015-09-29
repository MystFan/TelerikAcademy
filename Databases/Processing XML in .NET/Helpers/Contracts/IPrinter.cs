namespace Helpers.Contracts
{
    using System.Collections.Generic;

    public interface IPrinter
    {
        void Print(IEnumerable<string> items);

        void Print(string message);
    }
}
