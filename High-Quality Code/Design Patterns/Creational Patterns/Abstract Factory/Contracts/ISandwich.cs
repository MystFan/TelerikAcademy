namespace Abstract_Factory.Contracts
{
    using System.Collections.Generic;

    public interface ISandwich
    {
        List<string> Ingredients { get; }

        string Garnish { get; }

        bool HasGarnish();
    }
}
