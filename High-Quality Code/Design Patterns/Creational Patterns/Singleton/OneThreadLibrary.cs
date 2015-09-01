namespace Creational_Patterns
{
    using System;
    using System.Collections.Generic;

    public class OneThreadLibrary
    {
        private static OneThreadLibrary libraryInstance;

        private readonly List<IReadable> readableItems = new List<IReadable>();

        private OneThreadLibrary()
        {
        }

        public static OneThreadLibrary Instance
        {
            get
            {
                if (libraryInstance == null)
                {
                    libraryInstance = new OneThreadLibrary();
                }

                return libraryInstance;
            }
        }

        public List<IReadable> ReadableItems 
        {
            get
            {
                return new List<IReadable>(this.readableItems);
            }
        }

        public void Add(IReadable readableItem)
        {
            if (readableItem == null)
            {
                throw new ArgumentException("Library item cannot be null");
            }

            this.readableItems.Add(readableItem);
        }
    }
}