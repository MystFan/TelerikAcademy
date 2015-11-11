namespace Library
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        int Contains(string firstString, string secondString);
    }
}
