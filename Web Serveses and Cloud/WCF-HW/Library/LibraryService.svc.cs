namespace Library
{
    public class LibraryService : ILibraryService
    {
        public int Contains(string firstString, string secondString)
        {
            int index = -1;
            int counter = 0;
            while (true)
            {
                index = firstString.ToLower().IndexOf(secondString.ToLower(), index + 1);
                if (index < 0)
                {
                    break;
                }

                counter++;
            }

            return counter;
        }
    }
}
